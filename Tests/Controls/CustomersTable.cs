using Infra.Helper.TableHelper;
using Infra.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Controls
{
    public class CustomersTablePage : Table
    {
        public CustomersTablePage(AbstractWebActions driver) : base(driver, "//table[@id='customers']")
        {
        }

        public string GetTableCellTextByXpath(int searchColumn, string searchText, int returnColumnText)
        {
            try
            {
                return GetRowByColumnIndexAndCellValue(searchColumn, searchText).GetCellByIndex(returnColumnText).GetText();
            }
            catch
            {
                throw new Exception("Faild while getting text from table");
            }
        }
    }
}
