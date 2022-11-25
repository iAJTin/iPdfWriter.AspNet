@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\lib\iTin.Utilities\iTin.Utilities.Pdf\iTin.Utilities.Pdf.Writer\iTin.Utilities.Pdf.Writer.AspNet\bin\Debug\net461\iTin.Utilities.Pdf.Writer.AspNet.dll ..\documentation
         
PAUSE
