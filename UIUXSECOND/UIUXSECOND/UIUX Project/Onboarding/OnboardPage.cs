using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UIUXSECOND 
{ 


    public class OnboardPage : BasePage
    {

        public string cnamee { get; set; }
        public string prname { get; set; }
        public string premail { get; set; }
        public string leademail { get; set; }

      //  public string premail { get; set; }




        By onsidenav = By.CssSelector("#introJS-item-6 > div");
        By nonbordbbtn = By.XPath("//button[text()='New Onboarding']");
        By onboardname = By.Id("companyName");
        By prnamee = By.Id("accountManager");
        By premaill = By.Id("accountManagerEmail");
        By leadmail = By.Id("leadEmails");
        By bc = By.Id("primaryCategoryId");   //label[text()='Business category']
        //  By bcselection = By.XPath("//select[@id='primaryCategoryId']/option[7]");
        By bcselection = By.XPath("//li[text()='Animals & Pets']");

        // By topscroll = By.XPath("//h1[text()='New Onboarding]");
        By savebtn = By.XPath("//span[text()='Save']");
        By featurebox = By.XPath("//span[text()='Yes']");
       // By successmsg = By.XPath("//h1[text()='new onboarding']");
        

        public void onboardp()
        {
            cli(onsidenav, nonbordbbtn);
            cle(nonbordbbtn);
          
            sendkeyy(onboardname, cnamee);
            sendkeyy(prnamee, prname);
            sendkeyy(premaill, premail);
            sendkeyy(leadmail, leademail);
            Thread.Sleep(2000);
            //scroll to specific eelement
            WebElement elem = (WebElement)driver.FindElement(By.XPath("//label[text()='Setup instructions']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Scroll to bottom
            js.ExecuteScript("arguments[0].scrollIntoView()", elem);
            Thread.Sleep(2000);
            // cli(bc, bcselection);
            cle(bc);
            cle(bcselection);
            Thread.Sleep(3000);
            //scroll to specific eelement
            WebElement elem1 = (WebElement)driver.FindElement(By.XPath("//h4[text()='Onboarding details']"));
            IJavaScriptExecutor jss = (IJavaScriptExecutor)driver;
            //Scroll to bottom
            jss.ExecuteScript("arguments[0].scrollIntoView()", elem1);
            Thread.Sleep(2000);

            clickk(savebtn,featurebox );
           
           // clickk(featurebox, successmsg);   

           // Thread.Sleep(2000);







        }

















    }







    
}
