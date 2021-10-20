using TechTalk.SpecFlow;

namespace PG.E2ETests.Hooks
{
    class Hooks
    {
    }

    [Binding]
    public class WebDriverHooks
    {
        [BeforeScenario]
        public void SetUp()
        {
        }

        [AfterScenario]
        public void TearDown()
        {
        }
    }
}
