using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIUXSECOND
{

    [TestClass]
    public class OnboardTC
    {


        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
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

        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "onboardtc", DataAccessMethod.Sequential)]

        public void onboardtc()
        {

            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login");

            string company = TestContext.DataRow["company"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            LoginPage log = new LoginPage();
            log.Companyn = company;
            log.Usern = username;
            log.Passn = password;
            log.loginp();


            //onboarding

            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Onboarding");

            string onname = TestContext.DataRow["cname"].ToString();
            string prnamee = TestContext.DataRow["prname"].ToString();
            string premaill = TestContext.DataRow["premail"].ToString();
            string leadmaill = TestContext.DataRow["lead"].ToString();

            OnboardPage page = new OnboardPage();
            page.cnamee = onname;
            page.prname = prnamee;
            page.premail = premaill;
            page.leademail = leadmaill;
            page.onboardp();




        }































    }




}
