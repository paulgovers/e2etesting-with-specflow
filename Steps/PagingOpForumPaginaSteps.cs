using FluentAssertions;
using E2ETests.Pages;
using PG.E2ETests.Helper;
using TechTalk.SpecFlow;

namespace E2ETests.Steps
{
    [Binding]
    public class PagingOpForumPaginaSteps
    {
        private ForumTopicCannondalePage forumTopicCannondalePage;

        public PagingOpForumPaginaSteps(WebDriverContext webDriverContext)
        {
            forumTopicCannondalePage = new ForumTopicCannondalePage(webDriverContext);
        }
        [Given(@"Anonieme gebruiker op forum webpagina")]
        public void GegevenAnoniemeGebruikerOpForumWebpagina()
        {
            forumTopicCannondalePage.GoToForumTopicPage();
        }

        [When(@"Ik naar de volgende pagina ga")]
        public void AlsIkNaarDeVolgendePaginaGa()
        {
            forumTopicCannondalePage.NextPage();
        }
        
        [Then(@"Open Pagina ""(.*)"" van topic Cannondale Super-V DH Achterrem vervangen")]
        public void DanOpenPaginaVanTopicCannondaleSuper_VDHAchterremVervangen(int p0)
        {
            var activePage = forumTopicCannondalePage.GetActivePageNumber();
            activePage.Should().Be("2");
        }

    
    }
}
