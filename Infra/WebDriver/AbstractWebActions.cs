using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;

namespace Infra.WebDriver
{
    public class AbstractWebActions : EventFiringWebDriver
    {
        private WebDriverWait explicitWait;
        private int defaultTimeoutMilliseconds = 30000;

        public AbstractWebActions(IWebDriver driver) : base(driver)
        {
            explicitWait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(defaultTimeoutMilliseconds));

        }
        public WebDriverWait ExplicitWait
        {
            get { return explicitWait; }
        }

        public int GetCountOfElements(By searchMechanisam)
        {
            return FindElements(searchMechanisam).Count;
        }

        public string GetTextFromElement(By searchMechanisam)
        {
            return FindElement(searchMechanisam).Text;
        }

        public virtual void ClickOnElement(By searchMechanisam)
        {
            FindElement(searchMechanisam).Click();
        }
        public virtual bool IsElementDisplayed(By searchMechanisam)
        {
           return FindElement(searchMechanisam).Displayed;
        }
        public virtual string GetElementText(By searchMechanisam)
        {
            return FindElement(searchMechanisam).Text;
        }
        public virtual void TypeToElement(By searchMechanisam, string textToType)
        {
            IWebElement element = FindElement(searchMechanisam);
            element.Clear();
            element.SendKeys(textToType);
        }

    }
}