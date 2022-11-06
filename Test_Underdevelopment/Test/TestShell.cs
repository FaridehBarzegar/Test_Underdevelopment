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
   public class TestShell 
    {
        WebDriver driver;
        Login login;
        TestLogin testLogin;
        Cartable cartable;
        Shell shell;
      
        public TestShell( )
        {

           driver = new ChromeDriver();
        }
        [OneTimeSetUp]
        public void Initialize()
        {
            //driver.Url = "https://192.168.12.145";
            testLogin = new TestLogin( );
            testLogin.TestLogin_succeed_correctInfo( );

        }
        [Test]
        public void TestShell_Succceed_OpenCartable()
        {
            //testLogin.TestLogin_succeed_correctInfo( );
           
            cartable = new Cartable(driver );
            shell = new Shell(driver);
            cartable = shell.Shell_Succeed_OpenCartable();
        }

        [OneTimeTearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}
