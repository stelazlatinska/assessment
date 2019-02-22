using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MyApp.Support
{
    [Binding]
    public class Hooks
    {
        private readonly IWebDriver driver;
        private readonly ScenarioContext context;

        public Hooks(IWebDriver driver, ScenarioContext context)
        {
            this.driver = driver;
            this.context = context;
        }

        [AfterScenario]
        public void AfterFeature()
        {
            driver.Dispose();
            driver.Quit();
        }

    }
}
