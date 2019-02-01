using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Amazon.StepsDefinitions
{
    [Binding]
    public sealed class ProductDetailsSteps
    {
        IWebDriver driver;

        [Given(@"I navigate to Amazon homepage")]
        public void GivenINavigateToAmazonHomepage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/");
        }

        [Given(@"I search for Wrist Watch")]
        public void GivenISearchForWristWatch()
        {
            
        }

        [Given(@"I click on one of the search results displayed")]
        public void GivenIClickOnOneOfTheSearchResultsDisplayed()
        {
           
        }

        [Then(@"the product price is displayed")]
        public void ThenTheProductPriceIsDisplayed()
        {
           
        }

    }
}
