using OpenQA.Selenium;
using Xunit;

namespace Abb.Tests;

public class LoginTests(IWebDriver webDriver)
{
    [Fact]
    public void TestChangeUserName()
    {
        webDriver.FindElement(By.Id("profile-link")).Click();
        webDriver.FindElement(By.Id("name")).Clear();
        webDriver.FindElement(By.Id("name")).SendKeys("Janek");
        string currentValue = webDriver.FindElement(By.Id("name")).GetAttribute("value");
        Assert.Equal("Janek", currentValue);
        webDriver.FindElement(By.Id("save-profile")).Click();
        string message = webDriver.FindElement(By.Id("success-msg")).Text;
        Assert.Equal("Profil został zaktualizowany", message);
    }
}