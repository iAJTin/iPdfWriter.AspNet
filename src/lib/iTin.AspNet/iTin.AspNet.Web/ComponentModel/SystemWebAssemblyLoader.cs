
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;

namespace iTin.AspNet.Web.ComponentModel
{
    /// <summary>
    /// Static class for try to load the <strong>System.Web</strong> assembly.
    /// </summary>
    internal static class SystemWebAssemblyLoader
    {
        static SystemWebAssemblyLoader()
        {
            var clrMajorVersion = 2;

            try
            {
                clrMajorVersion = GetClrMajorVersion();
            }
            catch (SecurityException)
            {
            }

            if (clrMajorVersion == 2)
            {
                SystemWeb = Load("System.Web, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
            }

            if (clrMajorVersion == 4 || SystemWeb == null)
            {
                SystemWeb = Load("System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
            }
        }

        public static Assembly SystemWeb { get; }


        private static int GetClrMajorVersion()
        {
            var clrVersion = 0;
            var versionStr = RuntimeEnvironment.GetSystemVersion();

            var regex = new Regex("[0-9]", RegexOptions.Compiled | RegexOptions.Singleline);
            var match = regex.Match(versionStr);
            if (match.Success)
            {
                int.TryParse(match.Value, out clrVersion);
            }

            return clrVersion;
        }

        private static Assembly Load(string name)
        {
            try
            {
                return Assembly.Load(name);
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }
    }
}
