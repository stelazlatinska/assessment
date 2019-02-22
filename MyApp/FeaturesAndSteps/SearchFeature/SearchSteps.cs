using System;
using Fourth.Automation.Framework.Extension;
using MyApp.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MyApp.FeaturesAndSteps.DemoFeature
{
    [Binding]
    public class SearchSteps
    {
        private readonly ScenarioContext context;
        private readonly SearchPage searchPage;

        public SearchSteps(ScenarioContext context, SearchPage searchPage)
        {
            this.context = context;
            this.searchPage = searchPage;
        }

        [Given(@"Flickr page is opened")]
        public void GivenFlickrPageOpens()
        {
            searchPage.NavigateToPage();
        }

        [Then(@"The search field is present")]
        public void ThenSearchFieldsIsPresent()
        {
            Assert.True(searchPage.SearchBox.Exist(), "Search is Present");
        }

        [When(@"Search for images with one tag")]
        public void WhenSearchForImageWithOneTag()
        {
            searchPage.SearchForImage("sunrise");
        }

        [Then(@"The first image contains the search tag")]
        public void ThenTheImagesContainTheSearchTag()
        {
            Assert.IsTrue((searchPage.ImageTags[13].Text).Contains("sunrise"));
        }


        [When(@"Search for images with nonexisting image tag")]
        public void WhenSearchForNonExistingTag()
        {
            searchPage.SearchForImage("nonexistingimagetag");
        }

        [Then(@"Error message shows")]
        public void ThenErrorMessageShows()
        {
            Assert.True(searchPage.NoRecordsErrorMessage.Exist(), "Error Message is Present");
        }
    }
}
