using OpenQA.Selenium;
using PG.E2ETests.Helper;
using PG.E2ETests.Pages;

namespace E2ETests.Pages
{
    class ForumTopicCannondalePage : BasePage
    {
       
        public IWebElement nextPageButton => driver.FindElement(By.CssSelector("a[rel='next']"));
       
       
        public By activePageSelector = By.CssSelector("li.active span");
        public IWebElement activePageSpan => driver.FindElement(activePageSelector);
        public IWebElement searchButton => driver.FindElement(By.CssSelector(".button-search"));

        public ForumTopicCannondalePage(WebDriverContext webDriverContext) : base(webDriverContext)
        {
        }

        public void GoToForumTopicPage()
        {
            driver.Navigate().GoToUrl("https://www.mountainbike.nl/forum/viewtopic.php?f=4&t=150554");
        }
        
        public void NextPage()
        {
            nextPageButton.Click();
        }
       
        public string GetActivePageNumber()
        {
            var spanWebElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(activePageSelector));
           // var spanWebElement = wait.Until(e => e.FindElement(activePageSelector));
            return spanWebElement.Text;
        }
    }
}
