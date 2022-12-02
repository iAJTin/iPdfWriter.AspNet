
using iTin.AspNet.Web.ComponentModel;

namespace iTin.AspNet.Web
{
    /// <summary>
    /// Specialization of <see cref="IAspDetector"/>.
    /// Try to detect if <strong>ASP</strong> is running on this system.
    /// </summary>
    public class AspDetector : IAspDetector
    {
        /// <summary>
        /// Determines if <strong>ASP</strong> if running on this system.
        /// </summary>
        public bool AspIsRunning
        {
            get
            {
#if DEBUG
                return HttpContextAccessor.Current != null;
#else
                    return !Environment.UserInteractive || HttpContextAccessor.Current != null;
#endif
            }
        }
    }
}
