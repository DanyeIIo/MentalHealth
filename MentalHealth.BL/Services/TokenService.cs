using MentalHealth.Core.Models;
using MentalHealth.Core.Models.Requests.Account;
using MentalHealth.Core.Models.Responses.Account;
using MentalHealth.Core.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MentalHealth.BL.Services
{
    public class TokenService : ITokenService
    {
        private readonly IOptions<TokenIssuerOptions> _optionsHandler;
        private readonly IUserClaimsFactory _factory;

        public TokenService(IOptions<TokenIssuerOptions> optionsHandler, IUserClaimsFactory factory)
        {
            _optionsHandler = optionsHandler;
            _factory = factory;
        }

        public async Task<AuthenticationResponse> CreateAuthenticationResponseAsync(User user, CancellationToken cancellationToken = default)
        {
            var options = _optionsHandler.Value;
            var tokenDescriptor = new JwtSecurityToken(
                issuer: "http://localhost:5000",
                audience: "http://localhost:5000",
                notBefore: DateTime.UtcNow,
                claims: new ClaimsIdentity(await _factory.GetClaimsAsync(user), JwtBearerDefaults.AuthenticationScheme).Claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromDays(7)),
                signingCredentials: new(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(options.Secret)), SecurityAlgorithms.HmacSha256));
            
            var a = new JwtSecurityTokenHandler();
            var accessToken = a.WriteToken(tokenDescriptor);
            return new() { AccessToken = accessToken, UserId = user.Id };
        }
    }
}
