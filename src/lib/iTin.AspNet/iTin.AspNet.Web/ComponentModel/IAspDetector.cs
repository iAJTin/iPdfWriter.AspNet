
namespace iTin.AspNet.Web.ComponentModel
{
    /// <summary>
    /// Defines <strong>ASP</strong> common functions.
    /// </summary>
    public interface IAspDetector
    {
        /// <summary>
        /// Determines if <strong>ASP</strong> if running now.
        /// </summary>
        bool AspIsRunning { get; }
    }
}
