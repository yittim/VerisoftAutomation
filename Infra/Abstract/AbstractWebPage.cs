using Infra.WebDriver;

namespace Infra.Abstract
{
    public abstract class AbstractWebPage
    {
        protected readonly AbstractWebActions driver;

        public AbstractWebPage(AbstractWebActions driver)
        {
            this.driver = driver;
        }
    }
}
