using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;


namespace RegsiteringForm.UI_Element
{
    public class MainMenu
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public MainMenu()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How=How.CssSelector,Using = "#menu-item-25 > a")]
        public IWebElement Introduction { get; set; }

        [FindsBy(How=How.CssSelector,Using= "#menu-item-106 > a")]
        public IWebElement Selectors { get; set; }

        [FindsBy(How=How.CssSelector,Using = "#menu-item-35 > a")]
        public IWebElement SpecialElements { get; set; }

        [FindsBy(How=How.CssSelector,Using = "#menu-item-57 > a")]
        public IWebElement TestCases { get; set; }

        [FindsBy(How=How.CssSelector,Using = "#menu-item-58 > a")]
        public IWebElement TestScenarios { get; set; }

        [FindsBy(How=How.CssSelector,Using = "#menu-item-26 > a")]
        public IWebElement About { get; set; }
    }
}
