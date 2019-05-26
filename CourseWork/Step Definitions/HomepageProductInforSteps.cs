using CourseWork.Utilities;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace CourseWork.Step_Definitions
{
    [Binding]
    public class HomepageProductInforSteps
    {
        [Given(@"I navigate to giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
            Hooks.driver.Navigate().GoToUrl("http://www.qa1.giftrt.com");
            Hooks.driver.Manage().Window.Maximize();
        }
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            Hooks.driver.FindElement(By.XPath("//span[text()= 'Login']")).Click();
        }
        
        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            Hooks.driver.FindElement(By.XPath("//input[@id='user_email']")).SendKeys("temitope_afolabi4real@yahoo.com");
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            Hooks.driver.FindElement(By.XPath("//input[@id='user_password']")).SendKeys("Tester1234");
        }
        
        [When(@"I click sign in")]
        public void WhenIClickSignIn()
        {
            Hooks.driver.FindElement(By.XPath("//input[@id='btn_signin']")).Click();
        }
        
        [When(@"I click hometab")]
        public void WhenIClickTheHometab()
        {
            Thread.Sleep(5000);
            Hooks.driver.FindElement(By.XPath("//a[@class='brdcum']")).Click();
        }
        
        [When(@"I click free items")]
        public void WhenIClickFreeItems()
        {
            Hooks.driver.FindElement(By.XPath("//h3[text()='Giftrete-cycle']")).Click();
        }
        
        [When(@"I click wishlist")]
        public void WhenIClickWishlist()
        {
            Hooks.driver.FindElement(By.XPath("//h3[text()='Wishlist']")).Click();
        }
        
        [When(@"I click community")]
        public void WhenIClickCommunity()
        {
            Hooks.driver.FindElement(By.XPath("//h3[text()='Community']")).Click();
        }
        
        [Then(@"I have information about the products")]
        public void ThenIHaveInformationAboutTheProducts()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
