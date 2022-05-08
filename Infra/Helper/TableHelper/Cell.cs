using Infra.Abstract;
using Infra.WebDriver;
using OpenQA.Selenium;

namespace Infra.Helper.TableHelper
{
    public class Cell : AbstractWebPage
    {

        protected By cellBy;
        protected string cellXPath;
        private int cellIndex;

        public Cell(AbstractWebActions driver, string cellXPath, int cellIndex) : base(driver)
        {
            this.cellXPath = cellXPath;
            this.cellIndex = cellIndex;
            this.cellBy = By.XPath(cellXPath);

        }
        public  string GetCellXpath { get { return cellXPath; } }
        public  string GetText()
        {
            return driver.GetTextFromElement(cellBy);
        }

    }
}