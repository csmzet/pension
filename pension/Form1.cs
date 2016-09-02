using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
//using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Safari.Internal;
using OpenQA.Selenium.Safari.Internal.Handlers;

namespace pension
{
    public partial class Form1 : Form
    {
        private int width1280 = 1280;
        private int width600 = 600;
        private int width480 = 480;
        private int width320 = 320;

        private string firefoxNameVersion = "firefox_v47.0.1";
        private string safariNameVersion = "safari_v5.1.7";
        private string IENameVersion = "ie_v11";
        private string chromeNameVersion = "chrome_v53";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //************************* Firefox (Работает) ****************************************************
            //IWebDriver driverFirefox = new FirefoxDriver();
            //driverFirefox.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
            //driverFirefox.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(55));
            //driverFirefox.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));

            //driverWork driverFirefoxWork = new driverWork(driverFirefox);
            //driverFirefoxWork.autoTest(firefoxNameVersion, width1280);
            //driverFirefoxWork.autoTest(firefoxNameVersion, width600);
            //driverFirefoxWork.autoTest(firefoxNameVersion, width480);
            //driverFirefoxWork.autoTest(firefoxNameVersion, width320);
            //driverFirefox.Close();
            //************************* Firefox ****************************************************


            //************************* Safari 5.1.7 только на версии Selenium 2.47 *****************************************************
            /*IWebDriver driverSafari = new SafariDriver();
            driverSafari.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
            driverSafari.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(55));
            driverSafari.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));

            driverWork driverSafariWork = new driverWork(driverSafari);
            driverSafariWork.autoTest(safariNameVersion, width1280);
            driverSafariWork.autoTest(safariNameVersion, width600);
            driverSafariWork.autoTest(safariNameVersion, width480);
            driverSafariWork.autoTest(safariNameVersion, width320);
            driverSafari.Close();*/
            //************************* Safari 5.1.7 *******************************************************


            //************************* IE11 (Работает) *****************************************************
            IWebDriver driverIE = new InternetExplorerDriver();
            driverIE.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
            driverIE.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(55));
            driverIE.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));

            driverWork driverIEWork = new driverWork(driverIE);
            driverIEWork.autoTest(IENameVersion, width1280);
            driverIEWork.autoTest(IENameVersion, width600);
            driverIEWork.autoTest(IENameVersion, width480);
            driverIEWork.autoTest(IENameVersion, width320);
            driverIE.Close();
            //************************* IE11 *******************************************************



            //************************* chrome_v53 ( Работает и на 2,47) *****************************************************
            //IWebDriver driverChrome = new ChromeDriver();
            //driverChrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
            //driverChrome.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(55));
            //driverChrome.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));

            //driverWork driverChromeWork = new driverWork(driverChrome);
            //driverChromeWork.autoTest(chromeNameVersion, width1280);
            //driverChromeWork.autoTest(chromeNameVersion, width600);
            //driverChromeWork.autoTest(chromeNameVersion, width480);
            //driverChromeWork.autoTest(chromeNameVersion, width320);
            //driverChrome.Close();
            //************************* chrome_v53 *******************************************************
        }
    }
}
