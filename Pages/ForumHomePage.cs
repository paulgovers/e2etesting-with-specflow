using OpenQA.Selenium;
using PG.E2ETests.Helper;
using PG.E2ETests.Pages;

namespace E2ETests.Pages
{
    class ForumHomePage : BasePage
    {
        public IWebElement magnifierButton => driver.FindElement(By.CssSelector("li.search-view a"));
        public By searchInputSelector = By.CssSelector("input[name='search']");
        public IWebElement searchInput => driver.FindElement(searchInputSelector);
        public By numberOfResultsSelector = By.CssSelector("#resInfo-2");
        //public IWebElement numberOfResultsElement => driver.FindElement(numberOfResultsSelector);
        
        public ForumHomePage(WebDriverContext webDriverContext) : base(webDriverContext)
        {
        }
        public void GoToMTBHomePage()
        {
            driver.Navigate().GoToUrl("https://www.mountainbike.nl");
        }
        public void MagnifierButtonClick()
        {
            magnifierButton.Click();
        }
        public void SearchByKeyWord(string keyword)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(searchInputSelector));
            searchInput.SendKeys(keyword);
            searchInput.SendKeys(Keys.Enter);
        }

        public string GetNumberResults()
        {
            var numberOfResultsElement = wait.Until(e => e.FindElement(numberOfResultsSelector));
            return numberOfResultsElement.Text;
        }
    }
}
