using OpenQA.Selenium.Chrome;
using System;
using System.Reflection;

namespace Infra.WebDriver
{
    public class DriverFactory
    {

        public static AbstractWebActions CreateWebDriver(bool privateMode = false, bool changeDownloadDirectory = false, string downloadDirectory = null, bool enableAutomation = false)
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            path = path.Substring(0, path.LastIndexOf("/"));
            ChromeOptions options = new ChromeOptions();
            ChromeDriver chromeDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(path + @"\WebDriver\WebDriversExecutables\", "chromedriver.exe"), options);
            return new AbstractWebActions(chromeDriver);
        }
    }
}
