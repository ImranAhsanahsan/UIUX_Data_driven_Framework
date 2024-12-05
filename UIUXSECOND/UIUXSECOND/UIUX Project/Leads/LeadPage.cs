using AventStack.ExtentReports.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIUXSECOND
{
    public class LeadPage : BasePage
    {
        By Leadpage = By.XPath("//span[text()='Leads']");
        By Leadverify = By.XPath("//div[text()='Created']");

        public void leadPage()
        {
            clickk(Leadpage, Leadverify);

        }
    }  
}