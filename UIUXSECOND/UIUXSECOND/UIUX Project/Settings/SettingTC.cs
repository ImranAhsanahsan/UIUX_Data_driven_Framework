using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace UIUXSECOND
{

    [TestClass]

    public class SettingTC
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

        //agr ise comment kre ga to ya login page ki report nh bnay ga.
        [TestCleanup]
        public void TestCleanup()
        {
            BasePage.driver.Quit();
        }

        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "Settingtcc", DataAccessMethod.Sequential)]

        public void Settingtcc()
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Setting User Management");

            string company = TestContext.DataRow["company"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            LoginPage log = new LoginPage();  //class initialize
                   //property vise structure
            log.Companyn = company;
            log.Usern = username;
            log.Passn = password;
            log.loginp();         //object bnaya ha us class ki property ko use krna ka liya 


            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Setting User Management");

            string uname = TestContext.DataRow["uname"].ToString();
           // string uemail = TestContext.DataRow["username1"].ToString();


            SetingPage page = new SetingPage();
            page.usernamee = uname;
           // page.useremaill = uemail;
            page.Settingp();






        }









    }
    


}

*/
