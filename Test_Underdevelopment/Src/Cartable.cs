using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Underdevelopment.Src
{
   public class Cartable
    {

        protected WebDriver driver;
        private By m_recievedEntity = By.ClassName("jqgfirstrow");//need to improve
        private By m_newEntity = By.LinkText("جدید");
        private By m_newOutputLetter = By.LinkText("نامه صادره جدید");
        private By m_newInputLetter = By.LinkText("نامه داخلی جدید");
        private By m_newMemorandom = By.LinkText("یادداشت اداری جدید");
        private By m_newEform = By.LinkText("فرم جدید");
        private By m_refresh = By.LinkText("به روز رسانی");
        private By m_inboxCartable = By.Id("workSpaceNavPanelDefault");
        private By m_followUpCartable = By.LinkText("پیگیری ها");
        private By m_beingProcessingCartable = By.LinkText("در دست اقدام");
        private By m_Search = By.Name("searchText");
        private By m_setting = By.XPath("//img[@src='/Images/setting-icon.png']");
        private By m_unreadCounter = By.ClassName("entry-count");
        private By m_back = By.XPath("//img[@src='/Images/sign-out-option.png']");

        public Cartable(WebDriver driver)
        {
            this.driver = driver;
        }
        public Cartable Cartable_Succeed_Load()
        {
            driver.FindElement(m_recievedEntity);
            driver.FindElement(m_newEntity);
            driver.FindElement(m_newOutputLetter);
            driver.FindElement(m_newInputLetter);
            driver.FindElement(m_newMemorandom);
            driver.FindElement(m_newEform);
            driver.FindElement(m_refresh);
            driver.FindElement(m_inboxCartable);
            driver.FindElement(m_followUpCartable);
            driver.FindElement(m_beingProcessingCartable);
            driver.FindElement(m_Search);
            // driver.FindElement(m_Search);
            driver.FindElement(m_setting);
            driver.FindElement(m_unreadCounter);
            driver.FindElement(m_back);

            return new Cartable(driver);
        }
    }
}
