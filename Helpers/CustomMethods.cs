using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace AutomationCourseExlrt.Helpers
{
	public class CustomMethods
	{
		private static IWebDriver Driver;

		public CustomMethods(IWebDriver driver)
		{
			Driver = driver;
		}

		/*
		TODO 
			Implement Extensions methods 
		*/

		/// Check is Element clickable
		public static bool Click(IWebElement element)
		{
			if (element == null)
			{
				Console.WriteLine("Error[ClickOn]Input element is null.");
				return false;
			}
			try
			{
				element.Click();
				return true;
			}
			catch (Exception e)
			{
				// 1. Thrown when the target element is not visible.
				// 2. Thrown when the target element is no longer valid in the document DOM.
				Console.WriteLine("Error[ClickOn]: " + e.Message);
			}
			return false;
		}
		//Set methods
		public static void EnterText(IWebElement webElement, string text) => webElement.SendKeys(text);

		/// Selecting Element by Value
		public static bool SelectElementByValue(IWebElement webElement, string value)
		{
			SelectElement selectElement = new SelectElement(webElement);
			if (webElement == null)
			{
				Console.WriteLine("Error[SelectOn]Input element is null.");
				return false;
			}
			try
			{
				selectElement.SelectByValue(value);
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[SelectOn]: " + e.Message);
			}
			return false;
		}

		/// Selecting element by text
		public static bool SelectElementByText(IWebElement webElement, string text)
		{
			SelectElement selectElement = new SelectElement(webElement);
			if(webElement == null)
			{
				Console.WriteLine("Error[SelectOn]Input element is null.");
				return false;
			}
			try
			{
				selectElement.SelectByText(text);
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[SelectOn]: " + e.Message);
			}
			return false;
		}

		/// Selecting element by Index
		public static bool SelectElementByIndex(IWebElement webElement, int byIndex)
		{
			SelectElement selectElement = new SelectElement(webElement);
			if (webElement == null)
			{
				Console.WriteLine("Error[SelectOn]Input element is null.");
				return false;
			}
			try
			{
				selectElement.SelectByIndex(byIndex);
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[SelectOn]: " + e.Message);
			}
			return false;
		}

		/// Sum of Displayed option
		public static int AmountOfOption(IWebElement webElement)
		{
			SelectElement selectElement = new SelectElement(webElement);
			if (webElement == null)
			{
				Console.WriteLine("Error[SelectOn]Input element is null.");
				throw new ElementNotVisibleException("Element is unavailable");
			}
			var items = selectElement.Options.Count;
			Console.WriteLine(items);
			return items;
			
		}

		/// Check is element Enabled
		public static bool IsEnabled(IWebElement webElement)
		{
			if (webElement.Enabled)
			{
				LogUtil.Log("Field is enabled");
				return true;
			}
			else
			{
				LogUtil.Log("Field is not enabled");
				throw new ElementNotVisibleException("Error[Click]: Element is disabled");
				//return false;
			}
		}

		//Check link, need improvments
		public static bool IsLinkWorks(IWebElement webElement, IWebElement target)
		{
			webElement.Click();
			if (target.Text.Contains("Locators and Selenium"))
			{
				LogUtil.Log("Home page  works and header is visiable");
				Driver.Navigate().Back();
				return true;
			}
			else
			{
				LogUtil.Log("HomePage  doesnt work and header is not visiable");
				return false;
			}
		}

		/// Custom wait method, wait for appear
		public static bool CustomWaitMethod(IWebElement webElement, IWebDriver Driver)
		{
			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			if (webElement == null)
			{
				Console.WriteLine("Error[ClickOn]Input element is null.");
				return false;
			}
			try
			{
				wait.Until(d =>
				{
					if (webElement.Displayed)
					{
						LogUtil.Log("Element is displayed");
						return webElement;
					}
					return null;
				});
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[ClickOn]" + e.Message);
			}
			return false;
		}

		public static void CustomWaitMethodDisappear(IWebElement webElement, IWebDriver Driver)
		{
			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			wait.Until(d =>
			{
				if (!webElement.Displayed)
				{
					LogUtil.Log("Element is disappear");
					return webElement;
				}
				return null;
			});
		}
		public static void ActionsKeys(IWebElement webElement, string text, IWebDriver Driver)
		{
			Actions actions = new Actions(Driver);
			actions.Click(webElement)
				.SendKeys(text + Keys.Tab)
				.Build()
				.Perform();
		}

		public static void KeyboardActions(IWebElement webElement, IWebDriver Driver)
		{
			Actions actions = new Actions(Driver);
			actions.MoveToElement(webElement)
				.Click()
				.Perform();
		}

		//Get methods
		public static string GetText(IWebElement webElement)
		{
			if (webElement.Displayed)
			{
				LogUtil.Log("The text is: " + webElement.GetAttribute("value"));
				return webElement.GetAttribute("value");
			}
			else
			{
				LogUtil.Log("Field is not enabled, visiable or is empty");
				return "Field is not enabled";
			}
		}

		public static void ClearText(IWebElement webElement)
		{
			webElement.Clear();
		}

		// Create Screenshot
		public static void TakeScreenshot(IWebElement webElement)
		{
			Actions actions = new Actions(Driver);
			actions.MoveToElement(webElement)
				.Click()
				.Perform();
			((ITakesScreenshot)Driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
		}


	}
}
