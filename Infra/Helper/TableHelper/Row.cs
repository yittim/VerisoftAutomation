using Infra.Abstract;
using Infra.WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Helper.TableHelper
{
    public class Row : AbstractWebPage
    {
        protected By rowCBy;
        protected string rowXPath;

        public Row(AbstractWebActions driver,string rowXPath) : base(driver)
        {
            this.rowXPath = rowXPath;
            this.rowCBy = By.XPath(rowXPath);
        }

        public string GetRowXPath { get { return rowXPath; } }

        public Cell GetCellByIndex(int indexCell)
        {
            return new Cell(driver,rowXPath + "//td[" + indexCell + "]", indexCell);
        }


    }
}