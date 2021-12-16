using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MentalHealth.API.Shared;
using MentalHealth.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using MentalHealth.Core.Models.Requests.Account;
using System;

namespace MentalHealth.API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen();
            services.AddScoped<ApplicationExceptionFilter>();
            services.AddControllers(options =>
                options.Filters.Add<ApplicationExceptionFilter>());

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                    _configuration.GetConnectionString("DefaultConnection"), options =>
                        options.UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery))
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging()
                .UseSqlServer(_configuration.GetConnectionString("DefaultConnection"), x => x.MigrationsAssembly("MentalHealth.API"))
            );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new()
                {
                    Title = "MentalHealth.API",
                    Version = "v1"
                });

                c.CustomSchemaIds(x => x.FullName);
            })
            .AddUserServices(_configuration);


            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                _configuration.Bind(TokenIssuerOptions.Section, options);
                var tokenOptions = new TokenIssuerOptions();
                _configuration.Bind(TokenIssuerOptions.Section, tokenOptions);
                options.TokenValidationParameters.IssuerSigningKey =
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes(tokenOptions.Secret));
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Default", builder => builder.RequireAuthenticatedUser());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MentalHealth.API v1");
                    c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
                });
                    
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
