using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using PG.E2ETests.Helper;

namespace PG.E2ETests.Pages
{
    class BasePage
    {
        protected readonly WebDriverContext webDriverContext;
        protected readonly IWebDriver driver;
        protected readonly WebDriverWait wait;


        protected BasePage(WebDriverContext webDriverContext)
        {
            this.webDriverContext = webDriverContext;
            this.driver = this.webDriverContext.Driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5));
        }
    }
}
