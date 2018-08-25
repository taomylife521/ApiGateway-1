using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Tw.Core;
using Tw.Service.IdentityLogin;
using Microsoft.Extensions.Options;
using Tw.Service;
using Tw.Entity.IdentityServer;

namespace IdentityService
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        #region Fields
        AppConfig _AppConfig;
        IUserLoginService _IUserLoginService;
        #endregion

        #region Constructors
        public ResourceOwnerPasswordValidator(IOptions<AppConfig> __AppConfig, IUserLoginService __IUserLoginService)
        {
            _AppConfig = __AppConfig.Value;
            _IUserLoginService = __IUserLoginService;
        }
        #endregion

        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            APIUser APIUser = new APIUser();
            APIUser.UserName = context.UserName;
            APIUser.Password = context.Password;
            var LoginResult = _IUserLoginService.ValidateUser(APIUser);

            if (LoginResult == UserLoginResult.Successful)
            {
                context.Result = new GrantValidationResult(
                 subject: context.UserName,
                 authenticationMethod: "custom",
                 claims: GetUserClaims(context.UserName));
            }
            else
            {
                 //验证失败
                 context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "身份验证失败");
            }
        }
        //返回相应Claim
        private Claim[] GetUserClaims(string UserName)
        {
            return new Claim[]
            {
            new Claim("UserId", new Guid().ToString()),
            new Claim(JwtClaimTypes.Name,UserName)
            };
        }
    }
}
