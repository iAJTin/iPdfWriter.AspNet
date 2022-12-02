@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\lib\iPdfWriter\iPdfWriter.AspNet\bin\Debug\net461\iPdfWriter.AspNet.dll ..\documentation
         
PAUSE
