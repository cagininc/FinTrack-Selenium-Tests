using NUnit.Framework;
using Tests.Pages;

namespace Tests.TestCases
{
    public class LoginTests : TestBase
    {
        [Test]
        public void SuccessfulLoginTest()
        {
            driver.Navigate().GoToUrl("http://localhost:5173/login");

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("testuser1", "Testuser123!123");

            // login check
            Assert.That(driver.Url, Is.EqualTo("http://localhost:5173/search"));
        }
    }
}
