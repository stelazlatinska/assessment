using System.Configuration;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;

namespace MyApp.Pages
{
    public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
        }


        [FindsBy(How = How.ClassName, Using = "from-input")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.ClassName, Using = "alert-danger")]
        public IWebElement NoRecordsErrorMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "metadata-details li span.tag-name")]
        public IList<IWebElement> ImageTags { get; set; }


        public void NavigateToPage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["Website.Url"]);

        }

        public void SearchForImage(string searchTag)
        {
            SearchBox.ClearAndSendKeys(searchTag);
            SearchBox.SendKeys(Keys.Enter);
        }

    }
}
