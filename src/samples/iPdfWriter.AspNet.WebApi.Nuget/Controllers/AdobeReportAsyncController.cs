﻿
using System.Threading.Tasks;
using System.Web.Http;

using iTin.Utilities.Pdf.Writer.Operations.Result.Actions;

namespace iPdfWriter.AspNet.WebApi.Nuget.Controllers
{
    using Code;

    public class AdobeReportAsyncController : ApiController
    {
        public async Task GetAsync()
        {
            var result = await Sample01.GenerateAsync();
            if (result.Success)
            {
                var safeOutputData = result.Result;
                var downloadResult = await safeOutputData.Action(new DownloadAsync());
                if (!downloadResult.Success)
                {
                    // Handle error(s)
                }
            }
        }
    }
}
