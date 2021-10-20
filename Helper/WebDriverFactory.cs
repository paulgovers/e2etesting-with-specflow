using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace PG.E2ETests.Helper
{
    public class WebDriverFactory
    {
        public class WebDriverInstance : IDisposable
        {
            private readonly Lazy<IWebDriver> webDriver;

            public WebDriverInstance()
            {
                webDriver = new Lazy<IWebDriver>(CreateWebDriver);
            }

            private IWebDriver CreateWebDriver()
            {
                return new ChromeDriver();
            }

            public IWebDriver GetWebDriver()
            {
                return webDriver.Value;
            }

            public void Dispose()
            {
                if (webDriver.IsValueCreated)
                    webDriver.Value.Dispose();
            }
        }

        private readonly IObjectContainer container;
        private IWebDriver browserCreated;

        public WebDriverFactory(ScenarioContext scenarioContext)
        {
            container = scenarioContext.ScenarioContainer;
        }

        public IWebDriver CreateBrowser()
        {
            if (browserCreated == null)
            {
                browserCreated = container.Resolve<WebDriverInstance>().GetWebDriver();
                browserCreated.Manage().Window.Maximize();
            }
            return browserCreated;
        }
    }
}
