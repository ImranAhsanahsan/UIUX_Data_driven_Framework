using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SharpCompress.Common;
using System;


using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIUXSECOND
{
    


    public class BasePage
    {



        //make a static i webdriver to use it within any method
        public static IWebDriver driver;

        /* public static void browserinitialization()
         {
             // Specify the path to the ChromeDriver executable
             string chromeDriverPath = @"C:\Users\Imran\source\repos\UIUXSECOND\UIUXSECOND\bin\Debug\ChromeDriver.exe";

             // Set ChromeDriver options if needed (e.g., ChromeOptions)
             ChromeOptions options = new ChromeOptions();
             // Add options as needed

             // Create an instance of ChromeDriver with specified path and options
             driver = new ChromeDriver(chromeDriverPath, options);

             driver.Url = "https://my.apexstage2.xyz/login";
             driver.Manage().Window.Maximize();
         } */

        //Initializing driver here
        public static void browserinitialization()
         {
             

             driver = new ChromeDriver();

             driver.Url = "https://my.apextest.xyz/login";
             driver.Manage().Window.Maximize();
             // Thread.Sleep(12000);

         } 


        //Dynamic methods for action base

        //send keys with screen shots
        public void sendkeyy(By by, string data)
        {
            // driver.FindElement(by).SendKeys(data);

            try
            {

                IWebElement element = WaitForElement(by);
                element.SendKeys(data);
                TakeScreenshot(Status.Pass, "PAss test");
            }

            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");

            }
        }

        //simple send key
        public void simplesendkey(By by, string data)
        {
            driver.FindElement(by).SendKeys(data);

        }



        //dusra send key haa wait krwana ka liya
        public void sendkeyyy(By by, string data, By imran)
        {
            // driver.FindElement(by).SendKeys(data);

            try
            {

                IWebElement element = WaitForElement(by);
                element.SendKeys(data);
                IWebElement elementt = WaitForElement(imran);
                TakeScreenshot(Status.Pass, "PAss test");
            }

            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");

            }
        }


        //for click
        public void click(By by)
        {
            // driver.FindElement(by).Click();
            try
            {
                IWebElement element = WaitForElement(by);
                element.Click();
                TakeScreenshot(Status.Pass, "PAss test");

            }
            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");

            }

        }


        //simple click
        public void cli(By by, By imran)
        {
            // driver.FindElement(by).Click();
            driver.FindElement(by).Click();
            IWebElement element = WaitForElement(imran);
        }

        public void cle(By by)
        {
            driver.FindElement(by).Click();

        }


        //overload cclicck function isma hum ppehla bagair wait ka click krta ha then kisi element ka wot krta hha ka wo visible ho jyee or screen shot hum lele
        //  public void click(By by, By waitelement)
        public void clickk(By imran, By hashmi)
        {
            // driver.FindElement(by).Click();
            try
            {
                driver.FindElement(imran).Click();
               IWebElement element = WaitForElement(hashmi);

                TakeScreenshot(Status.Pass, "PAss test");

            }
            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");

            }
        }

        //claer
        public void clear(By by)
        {
            // driver.FindElement(by).Clear();
            try
            {
                IWebElement element = WaitForElement(by);
                element.Clear();
                TakeScreenshot(Status.Pass, "PAss test");
            }
            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");
            }
        }


        public string Textt(By by)
        {
            //string text = driver.FindElement(by).Text;
            //return text;


            IWebElement element = WaitForElement(by);
            string text = element.Text;
            return text;


        }


        //Method for river close///////////////
        public static void TestClose()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        ///end of method close//

        //////////////////// Code for Wait working all type of wait include Init/////////////////////////


        //wait code working gpt copy
        public IWebElement WaitForElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

            return wait.Until(driver =>
            {
                IWebElement element = driver.FindElement(by);
                if (element.Enabled && element.Displayed)
                {
                    return element;
                }
                return null;
            });
        }







        /*   public IWebElement WaitForElement(By by)
           {
               IWebElement element;

               try
               {
                   element = driver.FindElement(by);
               }
               catch
               {
                   WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                   wait.Until(driver => IsPageReady(driver) == true && IsElementVisible(by) == true);
                   element = driver.FindElement(by);
               }

               return element;


           }
           private bool IsPageReady(IWebDriver driver)
           {
               return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete");
           }

           private bool IsElementVisible(By by)
           {
               if (driver.FindElement(by).Enabled || driver.FindElement(by).Displayed == true)
                   return true;

               else
                   return false;
           } */
        ///////////////////////////// End of wait code //////////////////////////////




        //Extent report work screen shot method new code////////////////////////////////
       
        public static void TakeScreenshot(Status status, string stepDetail)
        {
            string path = @"C:\Users\Imran\source\repos\UIUXSECOND\UIUXSECOND\bin\images\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            // Save the screenshot using the 'path' variable
            image_username.SaveAsFile(path + ".png");

            // Log the screenshot using ExtentReport
            ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());
        }

        //chat gpt code for screen shot
        /* public static void TakeScreenshot(Status status, string stepDetail)
         {
             try
             {
                 // Define the directory path
                 string directoryPath = @"C:\Users\Imran\source\repos\UIUXSECOND\UIUXSECOND\bin\images\";

                 // Create the directory if it doesn't exist
                 if (!Directory.Exists(directoryPath))
                 {
                     Directory.CreateDirectory(directoryPath);
                 }

                 // Define the file path with a unique timestamp
                 string filePath = Path.Combine(directoryPath, "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");

                 // Take screenshot
                 Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

                 // Save screenshot to file

                 //screenshot.SaveAsFile(filePath, ImageFormat.Png);
                 //screenshot.SaveAsFile(filePath);

                 // Log the screenshot using ExtentReport
                 ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(filePath).Build());
             }
             catch (Exception ex)
             {
                 // Handle any exceptions
                 Console.WriteLine("Error occurred while taking screenshot: " + ex.Message);
             }
         }*/

        //Screen shot OLD code//

        /*
       public static void TakeScreenshot(Status status, string stepDetail)
       {
           string path = @"C:\Users\Imran\source\repos\UIUXSECOND\UIUXSECOND\bin\images\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
           Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
           //image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);

           ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());

       }*/

    }
}





















