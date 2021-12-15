using MentalHealth.BL.Services;
using MentalHealth.Core;
using MentalHealth.Core.Models.Requests.Account;
using MentalHealth.Core.Repositories;
using MentalHealth.Core.Services;
using MentalHealth.DAL;
using MentalHealth.DAL.Repositories;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUserServices(this IServiceCollection serviceCollection, IConfiguration configuration) =>
            serviceCollection.Configure<TokenIssuerOptions>(options => configuration.Bind(TokenIssuerOptions.Section, options))
                .AddScoped<ITokenService, TokenService>()
                .AddScoped<IUserService, UserService>()
                .AddScoped<IUserClaimsFactory, UserClaimsFactory>()
                .AddSingleton<IHasher, Hasher>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IAdminService, AdminService>();
    }
}
