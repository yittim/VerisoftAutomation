using Infra.Abstract;
using Infra.WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Helper.TableHelper
{
    public abstract class Table : AbstractWebPage
    {
        private By tableBy;
        private string tableXPath;

        public Table(AbstractWebActions driver,string tableXPath) : base(driver)
        {
        }

        protected virtual Table GetNumberOfRows(out string numOfRows)
        {
            numOfRows = driver.GetCountOfElements(By.XPath(tableXPath + "//tr")).ToString();
            return this;
        }

        protected Row GetRowByColumnIndexAndCellValue(int columnIndex,string cellValue)
        {
            return new Row(driver, tableXPath + "//td[" + columnIndex + " and text()='" + cellValue + "']/parent::tr");
        }

        protected Row GetRowByIndex(string rowIndex)
        {
            return new Row(driver, tableXPath + "//tr" + "[" + rowIndex + "]");
        }

    }
}
