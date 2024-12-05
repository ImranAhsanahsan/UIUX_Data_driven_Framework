@ECHO OFF
ECHO Demo Automation Executed Started.

set testcategory=Login
set dllpath=C:\Users\Imran\source\repos\UIUXSECOND\UIUXSECOND\bin\Debug\UIUXSECOND.dll
set trxtoHTML=C:\Users\Imran\source\repos\UIUXSECOND\UIUXSECOND\bin\Debug\
set testsummaryreportPath=C:\Users\Imran\source\repos\UIUXSECOND\UIUXSECOND\bin\TestExecutionReports\

FOR /f %%a IN ('WMIC OS GET LocalDateTime ^| FIND "."') DO SET DTS=%%a
SET filename=%testcategory%_%DTS:~0,4%%DTS:~4,2%%DTS:~6,2%%DTS:~8,2%%DTS:~10,2%%DTS:~12,2%
echo %filename%

call "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\Common7\Tools\VsDevCmd.bat"
cd %testsummaryreportPath%


VSTest.Console.exe  %dllpath% /Logger:"trx;LogFileName=%testsummaryreportPath%\%filename%\%filename%.trx"

cd %trxtoHTML%
TrxToHTML.exe %testsummaryreportPath%%filename%\

PAUSE


1381,1476,1380, 1631

1431 1292 1527 1439

1767 1325 logged 1798, 1799, 1640, 1799,1798, 1800,1235
Hi Minhaj,

I was viewing that you are a Senior QA.

I am the owner of a Canadian based company looking for remote scrum masters with the knowledge of SQA.

Please share your resume, if you are interested.

Best,

Thomas



public class ExtentReport
    {

        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;


        public static void LogReport(string testcase)
        {
            extentReports = new ExtentReports();
            //dirpath = @"..\..\TestExecutionReports\" + '_' + testcase;
           
            dirpath = @"C:TestExecutionReports\" + '_' + testcase;
ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);

            htmlReporter.Config.Theme = Theme.Standard;

            extentReports.AttachReporter(htmlReporter);
        }
    }


questions 

chrome band nh hota jub sara test case execute krta ha tb

data driven ma aik hi file bna gyee ya har page ki alag alag

extent report ma multiple column kysa rakhta han 

property vise ma inherit krna lazmi ha kya 

