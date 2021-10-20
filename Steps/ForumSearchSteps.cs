using E2ETests.Pages;
using PG.E2ETests.Helper;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace E2ETests.Steps
{
    [Binding]
    public class ForumSearchSteps
    {
        private readonly ForumHomePage forumHomePage;

        public ForumSearchSteps(WebDriverContext webDriverContext)
        {
            forumHomePage = new ForumHomePage(webDriverContext);
        }
        [Given(@"User On Forum website")]
        public void GivenUserOnForumWebsite()
        {
            forumHomePage.GoToMTBHomePage();
        }

        [When(@"i click on magnifier")]
        public void WhenIClickOnMagnifier()
        {
            forumHomePage.MagnifierButtonClick();
        }


        [When(@"i search on keywords '(.*)'")]
        public void WhenISearchOnKeywords(string p0)
        {
            forumHomePage.SearchByKeyWord("Cannondale Super-V 4000 DH - replace rear brakes Sachs power disc");
        }
        
        [Then(@"Search result are shown")]
        public void ThenSearchResultAreShown()
        {
            var numberOfResults = forumHomePage.GetNumberResults();
            numberOfResults.Should().StartWith("Ongeveer 1 resultaten");
        }
    }
}
