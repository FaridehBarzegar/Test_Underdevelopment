using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Underdevelopment.Src;

namespace Test_Underdevelopment.Test
{
    
 public class TestLogin
    {
        WebDriver driver;
        Login login;
        Shell shell;

        public TestLogin( )
        {
            
        }
        [OneTimeSetUp]
        public void Initialize()
        {
            driver = new ChromeDriver( );
            driver.Url = "https://192.168.12.145";
        }
        [Test, Order(1)]
        public void TestLogin_Succeed_OpenLoginPage()
        {
            Login login = new Login(driver);
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(5));
            login = login.Login_Succeed_OpenLoginPage();
        }
        [Test, Order(2)]
        public void TestLogin_Succeed_CorrectInfo()  
        {
            Shell shell = new Shell(driver);
            Login login = new Login(driver);
            shell = login.Login_succeed_correctInfo("administrator", "1");
            
        }
        [OneTimeTearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}

