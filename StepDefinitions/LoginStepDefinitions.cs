using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowSelenium.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private IWebDriver driver;

        [Given(@"Open Browser")]
        public void GivenOpenBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Given(@"Enter url")]
        public void GivenEnterUrl()
        {
            driver.Url = "https://careers.google.com/";
        }
        [When(@"Click on sign in button")]
        public void WhenClickOnSignInButton()
        {
            driver.FindElement(By.XPath("//a[@class='gc-account-menu-bar__sign-in gc-h-larger-tap-target']")).Click();
        }

        [Then(@"check that new window is opened")]
        public void ThenCheckThatNewWindowIsOpened()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Manage().Window.Maximize();
        }

        [When(@"enter email and password")]
        public void WhenEnterEmailAndPassword()
        {
            
            driver.FindElement(By.XPath("//input[@id='identifierId']")).SendKeys("taskasignment@gmail.com");
            driver.FindElement(By.XPath("//span[normalize-space()='Next']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Name("Passwd")).SendKeys("Asdfgh#123");
            Thread.Sleep(1000);
            

        }
        [When(@"Click on next button")]
        public void WhenClickOnNextButton()
        {
            driver.FindElement(By.XPath("//span[normalize-space()='Next']")).Click();
            Thread.Sleep(4000);
            driver.Close();
        }



   


    }
}