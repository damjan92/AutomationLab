using AutomationCourseExlrt.Helpers;
using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using OpenQA.Selenium.Interactions;

namespace AutomationCourseExlrt.Pages
{
	class JavascriptExecutorTask1 : BasePage
	{
		

		public JavascriptExecutorTask1(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		//private IWebDriver InitializeDriver(BrowserType browserType)
		//{
		//	switch (browserType)
		//	{
		//		case BrowserType.Chrome:
		//			ChromeOptions chromeOptions = new ChromeOptions();
		//			return new ChromeDriver(chromeOptions);
		//		case BrowserType.Firefox:
		//			return new FirefoxDriver();
		//		default:
		//			throw new ArgumentException($"Unknown argument value {browserType}", nameof(browserType));
		//	}
		//}
		//
		//public void SetConfig()
		//{
		//	Driver = InitializeDriver(BrowserType.Chrome);
		//	Driver.Navigate().GoToUrl("https://www.google.com/");
		//	Driver.Manage().Window.Maximize();
		//}

		public static void TakeScreenshot(IWebElement webElement)
		{
			Actions actions = new Actions(Driver);
			actions.MoveToElement(webElement)
				.Build()
				.Perform();
			((ITakesScreenshot)Driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
		}

		public void JSCreateBorderFirstButton()
		{
			var jsDriver = (IJavaScriptExecutor)Driver;
			
			var element = Driver.FindElement(By.CssSelector("div[class='FPdoLc lJ9FBc'] input[name='btnK']"));
			string markupJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: blue"";";
			jsDriver.ExecuteScript(markupJavascript, new object[] { element });
			TakeScreenshot(element);
		}

		public void JSCreateBorderSecondButton()
		{
			var jsDriver = (IJavaScriptExecutor)Driver;
			var element = Driver.FindElement(By.CssSelector("div[class='FPdoLc lJ9FBc'] input[name='btnI']"));
			string markupJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: blue"";";
			jsDriver.ExecuteScript(markupJavascript, new object[] { element });
			TakeScreenshot(element);
		}

	}
}
