using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
namespace UIUXSECOND
{


    public class SetingPage : BasePage
    {
        //properties for input
        public string usernamee { get; set; }
       // public string useremaill { get; set; }


        //Locators
        By Settingtab = By.XPath("//span[text()='Settings']");
        By settingvery1 = By.XPath("//span[text()='User Management']");
        By settingvery2 = By.XPath("//button[text()='Add New']");
        By usernam = By.Id("username");
        By useremail = By.Id("email");
        By sendbtn = By.XPath("//button[text()='Send Invite']");
        By btnsuccess = By.XPath("//div[text()='Invitation has been sent successfully']");
        By emailsearch=By.XPath("//div[@class='row']//input[@class='inovua-react-toolkit-text-input__input']//following::div//parent::div[@class='InovuaReactDataGrid__column-header__content InovuaReactDataGrid__box--ellipsis' and text()='Email']//following::input[1]");



        public void Settingp()
        {
            click(Settingtab);
           // Thread.Sleep(8000);
           //yahan pe tt dalna ha elementt ma 
            IWebElement element = WaitForElement(settingvery1);
           
            Assert.AreEqual(settingvery1, settingvery1);
            cli(settingvery1, settingvery2);
            sendkeyy(usernam, usernamee);
            //sendkeyy(useremail, useremaill);

            //Unique email work working
            string uniqueEmail = GenerateUniqueEmail();
            sendkeyy(useremail, uniqueEmail);

            clickk(sendbtn,btnsuccess);

            click(emailsearch);
            sendkeyy(emailsearch, uniqueEmail);

            //sendkeyy(company, Companyn);
        }

        public string GenerateUniqueEmail()
        {
            // Append a unique timestamp to the base email address
            string baseEmail = "imran"; // Modify as needed
            string uniqueEmail = $"{baseEmail}_{DateTime.Now.Ticks}@gmail.com";

            return uniqueEmail;
        }



    }



    
}

*/