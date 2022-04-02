using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace RegsiteringForm.UI_Element
{
    public class Homepage
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Homepage()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How=How.CssSelector,Using = "#page-17 > header > h1")]
        public IWebElement Headline { get; set; }
    }
}
