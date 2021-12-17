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
	class JavascriptExecutorTask2 : BasePage
	{
		public JavascriptExecutorTask2(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}


		public void JSCreateBorderDropdown()
		{
			var jsDriver = (IJavaScriptExecutor)Driver;

			var DropdownPage = Driver.FindElement(By.CssSelector("a[href='pages/Dropdown.html']"));
			var element = Driver.FindElement(By.CssSelector("#dropdown1"));

			CustomMethods.Click(DropdownPage);
			CustomMethods.Click(element);

			System.Threading.Thread.Sleep(2000);

			CustomMethods.SelectElementByText(element, "Appium");
			string markupJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: blue"";";
			jsDriver.ExecuteScript(markupJavascript, new object[] { element });
			TakeScreenshot(element);
		}

		public static void TakeScreenshot(IWebElement webElement)
		{
			Actions actions = new Actions(Driver);
			actions.MoveToElement(webElement)
				.Build()
				.Perform();
			((ITakesScreenshot)Driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
		}

	}
}
