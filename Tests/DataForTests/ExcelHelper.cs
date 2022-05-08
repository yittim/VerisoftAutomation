using NPOI.XSSF.UserModel;
using System;
using System.Linq;
using System.Reflection;

namespace Tests.DataForTests
{
    public static class ExcelHelper
    {

        public static CustomersDataTest ReadXlsxDataToDataTest(int rowNumber)
        {
            //get file path
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
                path = path.Substring(0, path.LastIndexOf("/"));

            XSSFWorkbook workbook = new XSSFWorkbook(path + @"\DataForTests\DataForTest.xlsx");

            // get sheet
            var sheet = (XSSFSheet)workbook.GetSheetAt(0);
            try
            {
                CustomersDataTest dataTest = new CustomersDataTest();
                dataTest.searchColumn = (int)sheet.GetRow(rowNumber).GetCell(0).NumericCellValue;
                dataTest.searchText = sheet.GetRow(rowNumber).GetCell(1).StringCellValue;
                dataTest.returnColumnText = (int)sheet.GetRow(rowNumber).GetCell(2).NumericCellValue;
                dataTest.expectedText = sheet.GetRow(rowNumber).GetCell(3).StringCellValue;
                return dataTest;
            }

            catch
            {
                throw new Exception("Faild while getting Data from Excel");
            }

        }
    }

}
