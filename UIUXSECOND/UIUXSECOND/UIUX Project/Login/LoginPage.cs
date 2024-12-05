using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UIUXSECOND
{


    public class LoginPage : BasePage
    {

        //properties
        //#region properties page data
        public string Companyn { get; set; }
        public string Usern { get; set; }
        public string Passn { get; set; }



        By company = By.Name("apexchat-company");
        By username = By.Name("apexchat-username");
        By password = By.Name("apexchat-password");
        By btn = By.XPath("//button[text()='Login']");
        By test = By.XPath("//span[text()='Active Chats']");
        By cl = By.CssSelector("#introJS-item-5 > div");
        By cll = By.Name("//a[text()='My Reports']");
        //By tour = By.XPath("//button[text()='Close']");
        By locator = By.XPath("//strong[text()='Learn More']");

        public void loginp()
        {

            IWebElement element = WaitForElement(company);

           // Thread.Sleep(3000);
            sendkeyy(company, Companyn);
          //  Thread.Sleep(2000);
           WaitForElement(username);

            sendkeyy(username, Usern);

           // Thread.Sleep(2000);
            WaitForElement(password);

            sendkeyy(password, Passn);

            WaitForElement(btn);
            clickk(btn, test);

            Assert.AreEqual(locator,locator);
        }








    }












}
