
using System.Web.Http;

using iTin.Utilities.Abstractions.Writer.Operations.Results;

namespace iPdfWriter.AspNet.WebApi.Nuget.Controllers
{
    using Code;

    public class AdobeReportController : ApiController
    {
        public void Get()
        {
            var downloadResult = Sample01.Generate().Download();
            if (!downloadResult.Success)
            {
                // Handle error(s)
            }
        }
    }
}
