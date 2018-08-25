using System;
using System.Collections.Generic;
using System.Text;

namespace Tw.Core
{
    public interface ICookies
    {
        string GetCookies(string Key);

        void SetCookies(string Key, string Value);
    }
}
