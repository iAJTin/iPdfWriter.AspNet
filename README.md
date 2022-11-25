<p align="center">
  <img src="https://github.com/iAJTin/iPdfWriter.AspNet/blob/master/nuget/iPdfWriter.AspNet.png" height="32"/>
</p>
<p align="center">
  <a href="https://github.com/iAJTin/iPdfWriter.AspNet">
    <img src="https://img.shields.io/badge/iTin-iPdfWriter.AspNet-green.svg?style=flat"/>
  </a>
</p>

***

# What is iPdfWriter.AspNet?

**iPdfWriter.AspNet**, extends [iPdfWriter] to work in **AspNet (FullFramework)** projects, contains extension methods to download **PdfInput** instances as well as **OutputResult**, facilitating its use in this environment.

I hope it helps someone. :smirk:

# Install via NuGet

- From nuget gallery

<table>
  <tr>
    <td>
      <a href="https://github.com/iAJTin/iPdfWriter.AspNet">
        <img src="https://img.shields.io/badge/-iPdfWriter.AspNet-green.svg?style=flat"/>
      </a>
    </td>
    <td>
      <a href="https://www.nuget.org/packages/iPdfWriter.AspNet/">
        <img alt="NuGet Version" 
             src="https://img.shields.io/nuget/v/iPdfWriter.AspNet.svg" /> 
      </a>
    </td>  
  </tr>
</table>

- From package manager console

```PM> Install-Package iPdfWriter.AspNet```

# Usage

## Samples

### Sample 1 - Shows the use of synchronous download

    ```csharp   
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
    ```

### Sample 2 - Shows the use of asynchronous download by DownloadAsync action

    ```csharp   
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
    ```

# Documentation

 - Please see next link [documentation].

# How can I send feedback!!!

If you have found **iPdfWriter.AspNet** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iPdfWriter.AspNet**, please send me and email stating why this is so. I will use this feedback to improve **iPdfWriter.AspNet** in future releases.

My email address is 

![email.png][email] 


[email]: ./assets/email.png "email"
[documentation]: ./documentation/iTin.Utilities.Pdf.Writer.AspNet.md
[iPdfWriter]: https://github.com/iAJTin/iPdfWriter
