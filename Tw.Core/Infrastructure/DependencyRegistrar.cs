using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Tw.Core;
using Tw.Core.Infrastructure.DependencyManagement;

namespace Tw.Core.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddTransient<ICookies, Cookies>();
            services.AddTransient<ISessionManage, SessionManage>();
        }
    }
}