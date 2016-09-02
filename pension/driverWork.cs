using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.IE;
using System.Drawing;
using System.Threading;

namespace pension
{
    class driverWork
    {
        //поле
        IWebDriver driver { get; set; }
        private string title = "title";
        private string age = "age";
        private string question1 = "question1";
        private string question2 = "question2";
        private string question3 = "question3";
        private string final = "final";
        private string finalCalculator = "final-calculator";

        public driverWork(IWebDriver Driver)
        {
            driver = Driver;
        }

        public void ScreenBuild(string browserName, int screenWidth, string pageName)
        {
            Screenshot s1 = ((ITakesScreenshot)driver).GetScreenshot();
            string fullPath = browserName + "/" + pageName + "@" + screenWidth + ".jpeg";
            //string fullPath = screenWidth + ".jpeg";
            s1.SaveAsFile(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void autoTest(string browserName, int screenWidth)
        {
            driver.Navigate().GoToUrl("http://wsh1490.web-shop-hosting.com/vorfreude_result.de/index-if6.html");
            driver.Manage().Window.Size = new Size(screenWidth, 2048);

            driverWork driverWork = new driverWork(driver);

            driverWork.ScreenBuild(browserName, screenWidth, title);

            IWebElement button = driver.FindElement(By.Id("TitleCardStartButton"));
            button.Click();
            Thread.Sleep(3000);
            driverWork.ScreenBuild(browserName, screenWidth, age);
            button = driver.FindElement(By.Id("QuestionAgeWeiter"));
            button.Click();
            Thread.Sleep(3000);

            driverWork.ScreenBuild(browserName, screenWidth, question1);
            button = driver.FindElement(By.Id("QuestionFormWeiter"));
            //<a id="QuestionFormWeiter" href="#">Weiter</a>
            button.Click();

            Thread.Sleep(3000);
            //button = driver.FindElement(By.TagName("span")).FindElement(By.LinkText("+"));
            button = driver.FindElement(By.XPath("/html/body/section/div[3]/div/div[2]/div[2]/div[2]/table/tbody/tr/td[3]/span"));

            button.Click();
            button.Click();
            Thread.Sleep(2000);
            driverWork.ScreenBuild(browserName, screenWidth, question2);
            button = driver.FindElement(By.Id("QuestionFormWeiter"));
            button.Click();

            Thread.Sleep(3000);
            button = driver.FindElement(By.XPath("/html/body/section/div[3]/div/div[2]/div[2]/div[3]/table/tbody/tr/td[3]/span"));
            button.Click();
            button.Click();
            button.Click();
            button.Click();
            Thread.Sleep(3000);
            driverWork.ScreenBuild(browserName, screenWidth, question3);
            button = driver.FindElement(By.Id("QuestionFormWeiter"));
            button.Click();

            Thread.Sleep(3000);
            driverWork.ScreenBuild(browserName, screenWidth, final);
            button = driver.FindElement(By.XPath("/html/body/section/div[4]/div/div[5]/div/div/a"));
            button.Click();

            Thread.Sleep(3000);
            driverWork.ScreenBuild(browserName, screenWidth, finalCalculator);
        }
    }
}
