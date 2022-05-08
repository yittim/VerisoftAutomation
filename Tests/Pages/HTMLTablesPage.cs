using Infra.Abstract;
using Infra.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Controls;

namespace Tests.Pages
{
    public class HTMLTablesPage : AbstractWebPage
    {
        public HTMLTablesPage(AbstractWebActions driver) : base(driver)
        {
        }

        public CustomersTablePage GoToCustomersTablePage()
        {
            return new CustomersTablePage(driver);
        }
    }
}
