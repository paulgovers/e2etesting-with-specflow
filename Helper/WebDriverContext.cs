using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace PG.E2ETests.Helper
{
    public class WebDriverContext : IDisposable
    {
        private readonly Lazy<IWebDriver> webDriver;
        public IWebDriver Driver => webDriver.Value;

        public WebDriverContext(WebDriverFactory webDriverFactory, ScenarioContext scenarioContext)
        {
            webDriver = new Lazy<IWebDriver>(() => {
                var driver = webDriverFactory.CreateBrowser();
                scenarioContext.ScenarioContainer.RegisterInstanceAs(driver);
                return driver;
            });
        }

        public void NavigateTo(string url, bool waitForContentLoaded = false)
        {
            Driver.Navigate().GoToUrl(Uri(url));
        }

        private string Uri(string url)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (webDriver.IsValueCreated)
                webDriver.Value.Dispose();
        }
    }
}
