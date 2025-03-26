using OpenQA.Selenium;


namespace Tests.Pages
{


    public class LoginPage
    {
        private readonly IWebDriver driver;

        //page elements
        private IWebElement UsernameField=>driver.FindElement(By.Id("username"));
        private IWebElement PasswordField=>driver.FindElement(By.Id("password"));
        private IWebElement LoginButton=>driver.FindElement(By.Id("button[type='submit']"));

        //constructor method
        public LoginPage(IWebDriver driver)
        {
            this.driver= driver;
        }

    
    public void Login (string username,string password)
    {
        UsernameField.Clear();
        UsernameField.SendKeys(username);

        PasswordField.Clear();
        PasswordField.SendKeys(password);

        LoginButton.Click();
    }

    }
}