using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tw.Core.Infrastructure.DependencyManagement
{
    public interface IDependencyRegistrar
    {
        void Register(IServiceCollection services, IConfiguration Configuration);
    }
}
