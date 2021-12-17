using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Enums;
using AutomationCourseExlrt.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace AutomationCourseExlrt.Tests
{
	[TestFixture]
	class TestJavascriptExecutorTask1 : BaseTest
	{
		private IWebDriver InitializeDriver(BrowserType browserType)
		{
			switch (browserType)
			{
				case BrowserType.Chrome:
					ChromeOptions chromeOptions = new ChromeOptions();
					return new ChromeDriver(chromeOptions);
				case BrowserType.Firefox:
					return new FirefoxDriver();
				default:
					throw new ArgumentException($"Unknown argument value {browserType}", nameof(browserType));
			}
		}
		[SetUp]
		public void SetConfig()
		{
			Driver = InitializeDriver(BrowserType.Chrome);
			Driver.Navigate().GoToUrl("https://www.google.com/");
			Driver.Manage().Window.Maximize();
		}
		[Test]
		public void TestJSFirstButton()
		{
			JavascriptExecutorTask1 executorTask1 = new JavascriptExecutorTask1(Driver);
			executorTask1.JSCreateBorderFirstButton();
		}

		[Test]
		public void TestJSSecondButton()
		{
			JavascriptExecutorTask1 executorTask1 = new JavascriptExecutorTask1(Driver);
			executorTask1.JSCreateBorderSecondButton();
		}
		[TearDown]
		public void Cleaning()
		{
			Driver.Close();
		}

	}
}
