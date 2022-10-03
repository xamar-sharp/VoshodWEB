using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace VoshodWEB.Dependencies
{
    public interface IPlatformInfo
    {
        CultureInfo PlatformCulture { get; }
        string GetData();
    }
}
