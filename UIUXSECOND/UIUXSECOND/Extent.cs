﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIUXSECOND
{




    public class ExtentReport : BasePage
    {
        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;
        public static void LogReport(string testcase)
        {
            extentReports = new ExtentReports();
            dirpath = @"C:\Users\Imran\source\repos\UIUXSECOND\UIUXSECOND\bin\TestExecutionReports\TestExecutionReports";
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);
            htmlReporter.Config.Theme = Theme.Standard;
            extentReports.AttachReporter(htmlReporter);

        }
    }









}
