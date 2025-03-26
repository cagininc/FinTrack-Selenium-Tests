using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests

{

    public class TestBase
    {

        protected IWebDriver driver;

        [SetUp]

        public void Setup()
        {

            driver = new ChromeDriver();//open browser
            driver.Manage().Window.Maximize(); //maximize window

        }

        [TearDown]
    public void TearDown()
    {

        driver.Quit();//Close window 
         driver.Dispose();//clear
    }

    }
}