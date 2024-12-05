using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIUXSECOND
{
    [TestClass]

    public class LeadTC
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

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "leadpage", DataAccessMethod.Sequential)]

        public void leadpagee()
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

            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Lead Page");

            LeadPage page = new LeadPage();  //we need to create a object when ever we are going to call the method form other page 
            page.leadPage();

        }

    }


}
