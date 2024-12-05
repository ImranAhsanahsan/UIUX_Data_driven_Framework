using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIUXSECOND
{



    [TestClass]

    public class LoginTC
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

        //agr ise comment kre ga to ya login page ki report nh bnay ga 
        [TestCleanup]
        public void TestCleanup()
        {
            BasePage.driver.Quit();
        }

        //Data driven ka kam ka liya 
        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "login3", DataAccessMethod.Sequential)]
        public void login3()
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login Section");


            string company = TestContext.DataRow["company"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            LoginPage log = new LoginPage();
            // log.loginp2("imrant2", "imranagent", "123456");

            log.Companyn = company;
            log.Usern = username;
            log.Passn = password;
            log.loginp();


        }















    }
}