using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Tw.Core
{
    public interface ISessionManage
    {
        void SetValue(string Key,string Value);

        string GetValue(string Key);
    }
}
