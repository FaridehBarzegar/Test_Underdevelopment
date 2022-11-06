using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Underdevelopment.Src
{
   public class Login
    {
        WebDriver driver;
        private By m_userName = By.Id("Username");
        private By m_password = By.Id("Password");
        private By m_loginButton = By.Id("login-button");
        private By m_forgotPasswordLink = By.LinkText("رمز عبور را فراموش کرده ام");
        private By m_versionNumber = By.LinkText("1.000.00 : ویرایش");
        private By m_persianLanguage = By.LinkText("فارسی");
        private By m_englishLanguage = By.LinkText("English");
        public Login(WebDriver driver)
        {
            this.driver = driver;
        }
        public Login Login_Succeed_OpenLoginPage()
        {
            driver.FindElement(m_userName);
            driver.FindElement(m_password);
            driver.FindElement(m_loginButton);
            driver.FindElement(m_forgotPasswordLink);
            driver.FindElement(m_versionNumber);
            driver.FindElement(m_persianLanguage);
            driver.FindElement(m_englishLanguage);
            return new Login(driver);
        }
        public Shell Login_succeed_correctInfo(string userName, string password)
        {
            System.Threading.Thread.Sleep( 4000 );
            driver.FindElement(m_userName).SendKeys(userName);
            driver.FindElement(m_password).SendKeys(password);
            driver.FindElement(m_loginButton).Click();
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(3));
            return new Shell(driver);
        }
    }
}
