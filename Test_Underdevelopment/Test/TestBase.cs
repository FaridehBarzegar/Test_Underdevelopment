using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Underdevelopment.Src;

namespace Test_Underdevelopment.Test
{
   public class TestBase
    {

        public TestLogin testLogin;
        public Login login;
        public Shell shell;
        public Cartable cartable;
        public WebDriver driver;
        public TestBase()
        {
            testLogin = new TestLogin();
            login = new Login(driver);
            shell = new Shell(driver);
            cartable = new Cartable(driver);

        }
    }
}
