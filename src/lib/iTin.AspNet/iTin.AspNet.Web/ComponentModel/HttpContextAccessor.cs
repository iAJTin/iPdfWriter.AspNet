
using System.Reflection;
using System;

namespace iTin.AspNet.Web.ComponentModel
{
    /// <summary>
    /// 
    /// </summary>
    public static class HttpContextAccessor
    {
        private static readonly PropertyInfo Property;

        static HttpContextAccessor()
        {
            if (SystemWebAssemblyLoader.SystemWeb == null)
            {
                return;
            }

            try
            {
                var type = SystemWebAssemblyLoader.SystemWeb.GetType("System.Web.HttpContext");
                Property = type.GetProperty("Current", BindingFlags.Static | BindingFlags.Public);
            }
            catch
            {
                // nothing to do
            }
        }


        /// <summary>
        /// Try to get a reference to current web context
        /// </summary>
        public static object Current
        {
            get
            {
                try
                {
                    return Property?.GetValue(null, Array.Empty<object>());
                }
                catch
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Try to get the <strong>Server</strong> property of <strong>Current</strong> web context.
        /// </summary>
        public static object Server => GetPropertyValue(Current, "Server");

        /// <summary>
        /// Try to get the <strong>Request</strong> property of <strong>Current</strong> web context.
        /// </summary>
        public static object Request => GetPropertyValue(Current, "Request");

        /// <summary>
        /// Try to get the <strong>Url</strong> property of <strong>Current</strong> web context.
        /// </summary>
        public static Uri Url => (Uri)GetPropertyValue(Request, "Url");


        private static object GetPropertyValue(object obj, string name)
        {
            var pi = obj?.GetType().GetProperty(name, BindingFlags.Instance | BindingFlags.Public);

            return pi?.GetValue(obj, Array.Empty<object>());
        }
    }
}
