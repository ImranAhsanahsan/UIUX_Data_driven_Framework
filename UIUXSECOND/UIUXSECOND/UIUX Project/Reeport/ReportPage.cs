using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UIUXSECOND
{

    public class ReportPage : BasePage
    {


        public string namee { get; set; }
        public string emaill { get; set; }


        By cl = By.CssSelector("#introJS-item-5 > div");
        By cll = By.Name("//a[text()='My Reports']");
        By crebtnn = By.CssSelector(".container-fluid >div>div>button:nth-child(1)>svg");
       // By crebtn = By.XPath("//button[text()='Create report']");
        By name = By.Id("name");
        By email = By.Id("email");
        By date = By.CssSelector("#nested-select");
        By year = By.XPath("//li[text()='Year']");
        By pyear = By.XPath("//li[text()='Previous Year' and @value='FM/FY/C-1,LM/LY/C-1']");
        By sbtn = By.XPath("//button[@type='submit']");
        By repor = By.XPath("//span[text()='imrant2']");
        By succ = By.XPath("//b[text()='Success']");
        By resucc = By.XPath("//label[text()='Notification Endpoint']");

        public void reportp()
        {

            //Thread.Sleep(2000);
            clickk(cl,crebtnn);
           
           
            clickk(crebtnn,cll);
            Thread.Sleep(2000);
            click(name);
            sendkeyy(name, namee);
            sendkeyy(email, emaill);

            //javascript for scroll
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
            Thread.Sleep(1000);

           // WaitForElementt(date);
            

            cle(date);
            Thread.Sleep(1000);

          //  WaitForElementt(builder);
            //use for hover 
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//li[text()='Year']")))
                .Build().Perform();
            //

            Thread.Sleep(1000);

           // WaitForElementt(pyear);
            // cle(year); / old
            cle(pyear);

            Thread.Sleep(1000);

           // WaitForElementt(sbtn);
            cli(sbtn, succ);

            Thread.Sleep(1000);

           // WaitForElementt(repor);
            clickk(repor, resucc);

        }
    }















    
}
