using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowSelenium.StepDefinitions
{
    [Binding]
    public sealed class FeatureStepDefinitions
    {
        private IWebDriver driver;

        [Given(@"Open Browser")]
        public void GivenOpenBrowser()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
        }

        [Given(@"Enter url")]
        public void GivenEnterUrl()
        {
            driver.Url = "https://www.google.com/";
        }

        [Then(@"Search the text")]
        public void ThenSearchTheText()
        {
            driver.FindElement(By.XPath("//textarea[@id='APjFqb']")).SendKeys("Dhaka University");
            driver.FindElement(By.XPath("//textarea[@id='APjFqb']")).SendKeys(Keys.Enter);

            driver.Close();
        }


    }
}