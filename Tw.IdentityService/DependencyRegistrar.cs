using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace IdentityService
{
    public class DependencyRegistrar
    {
        public static void Register(IServiceCollection services, IConfiguration Configuration)
        {
            services.Configure<Tw.Core.AppConfig>(Configuration.GetSection("AppConfig"));
            services.AddTransient<Tw.Service.IdentityLogin.IUserLoginService, Tw.Service.IdentityLogin.UserLoginService>();
        }
    }
}
