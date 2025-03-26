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
            loginPage.Login("TestUser", "TestUserPassword!123");

            // login check
            Assert.That(driver.Url, Is.EqualTo("https://example.com/dashboard"));
        }
    }
}
