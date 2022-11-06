using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Underdevelopment.Src
{
   public class Shell
    {
        protected WebDriver driver;
        private By m_shellSidebar = By.Id("shell-sidebar");
        private By m_officeAutomation = By.Id("OfficeAutomation");
        private By m_calender = By.Id("PersonalInbox");
        private By m_personalInbox = By.Id("Calendar");
        private By m_people = By.Id("People");
        private By m_note = By.Id("Note");
        private By m_bulletinBoard = By.Id("BulletinBoard");
        private By m_changePasswordButton = By.LinkText("تغییر کلمه عبور");
        private By m_logOutButton = By.LinkText("خروج");
        private By m_postName = By.LinkText("مدير سيستم");
        private By m_post = By.LinkText("مدير سازمان الكترونيك پيوست ");
        private By m_dialogNotification = By.Id("dialogImportantConfirmation");
        public Shell(WebDriver driver)
        {
            this.driver = driver;
        }
        public Shell Shell_succeed_Load()
        {
            driver.FindElement(m_shellSidebar);
            driver.FindElement(m_officeAutomation);
            driver.FindElement(m_calender);
            driver.FindElement(m_personalInbox);
            driver.FindElement(m_people);
            driver.FindElement(m_note);
            driver.FindElement(m_bulletinBoard);
            driver.FindElement(m_changePasswordButton);
            driver.FindElement(m_logOutButton);
            driver.FindElement(m_postName);
            driver.FindElement(m_post);
            driver.FindElement(m_dialogNotification).FindElement(By.ClassName("divImpWarBtn")).Click();
            return new Shell(driver);
        }
        public Cartable Shell_Succeed_OpenCartable()
        {
            //driver.FindElement(m_dialogNotification).FindElement(By.ClassName("divImpWarBtn")).Click();
            driver.FindElement(m_officeAutomation).Click();
            return new Cartable( driver );
        }
    }
}
