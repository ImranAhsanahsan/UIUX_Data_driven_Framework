using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIUXSECOND
{


    [TestClass]


    public class ReportTC
    {
        [ClassCleanup]// ya tag sub sa end ma chulta ha humari execution ka 

        public static void TestClose()
        {
        }


        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }



        [AssemblyInitialize]
        public static void Assemblyinit(TestContext testContext)
        {
            ExtentReport.LogReport("TestReport");
            //       ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
        }

        [AssemblyCleanup]
        public static void Assemblyclean()
        {
            ExtentReport.extentReports.Flush();

        }

        [TestInitialize]
        public void TestInit()
        {
            BasePage.browserinitialization();
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            BasePage.driver.Quit();

        }

        [ClassInitialize] //ya tag sub sa pehla chulta ha jub humari execution statrrt hoti ha tb
        public static void ClassInit(TestContext context) //(TestContext context)
        {


        }



        [TestMethod]
        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "reportin3", DataAccessMethod.Sequential)]
        public void reportin3()
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login");

            string company = TestContext.DataRow["company"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            //is se humain login ka code dubara likhna ki zrurat nh ha ya wahin sa call kre ga 
            //LoginTC nn = new LoginTC();
            //nn.login3();

            LoginPage log = new LoginPage();   //ye object banyaa login ka 
            //log.loginp2("imrant2", "imranagent", "123456");

            //property vide structure
            log.Companyn = company;
            log.Usern = username;
            log.Passn = password;
            log.loginp();


            //Reporting data

            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Reporting");

            string reportname = TestContext.DataRow["reportname"].ToString();
            string remail = TestContext.DataRow["remail"].ToString();

            ReportPage page = new ReportPage();  // yahan pe is ka aik object bna ga 
            page.namee = reportname; 
            page.emaill = remail;
            page.reportp();



        }










    }



















}
