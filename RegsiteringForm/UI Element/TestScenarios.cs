using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;


namespace RegsiteringForm.UI_Element
{
    public class TestScenarios
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public TestScenarios()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How=How.CssSelector,Using = "#main-content > article.mh-loop-item.mh-clearfix.post-70.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-scenarios > div > header > h3 > a")]
        public IWebElement Clickingonregisterfor
        { get; set; }
    }
}
