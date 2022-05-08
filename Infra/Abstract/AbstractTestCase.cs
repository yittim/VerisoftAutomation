using Infra.WebDriver;
using NUnit.Framework;

namespace Infra.Abstract
{
    [TestFixture]
    public abstract class AbstractTestCase
    {
        private AbstractWebActions driver;

        protected AbstractWebActions Driver
        {
            get { return driver; }
            set { driver = value; }
        }
        [SetUp]
        public virtual void BeforeTest()
        {
            driver = DriverFactory.CreateWebDriver();
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void EndTest()
        {
            AfterTest();
            driver.Quit();
        }
        public virtual void AfterTest()
        {
        }
    }
}
