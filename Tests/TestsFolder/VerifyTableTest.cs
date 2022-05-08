using Infra.Abstract;
using NUnit.Framework;
using System.Configuration;
using Tests.Pages;
using Tests.DataForTests;

namespace Tests.TestsFolder
{
    [TestFixture]
    public class VerifyTableTest: AbstractTestCase
    {
        string actualCellText;

        [SetUp]
        public void BeforeTest()
        {
        }
        [Category("Reg")]
        [Test]
        public void VerifyTableTest_ID()
        {
            #region navigate
            Driver.Navigate().GoToUrl(@ConfigurationManager.AppSettings["W3SchoolsURL"]);
            #endregion

            Assert.True(VerifyCustomersTableCellText(ExcelHelper.ReadXlsxDataToDataTest(1)),"Not correct Value");


            Assert.True(VerifyCustomersTableCellText(ExcelHelper.ReadXlsxDataToDataTest(2)), "Not correct Value");

            Assert.True(VerifyCustomersTableCellText(ExcelHelper.ReadXlsxDataToDataTest(3)), "Not correct Value");

            Assert.True(VerifyCustomersTableCellText(ExcelHelper.ReadXlsxDataToDataTest(4)), "Not correct Value");


        }

        public bool VerifyCustomersTableCellText(CustomersDataTest customersDataTest)
        {
            int searchColumn = customersDataTest.searchColumn;
            string searchText = customersDataTest.searchText;
            int returnColumnText = customersDataTest.returnColumnText;
            string expectedText = customersDataTest.expectedText;
            actualCellText = new HTMLTablesPage(Driver).GoToCustomersTablePage().GetTableCellTextByXpath(searchColumn, searchText, returnColumnText);
            return expectedText.CompareTo(actualCellText)==0;
        }
    }
}
