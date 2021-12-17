using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationCourseExlrt.Base
{
	[TestFixture]
	public class BaseTest
	{

		public static IWebDriver Driver;

		private IWebDriver InitializeDriver(Enums.BrowserType browserType)
		{
			switch (browserType)
			{
				case Enums.BrowserType.Chrome:
					ChromeOptions chromeOptions = new ChromeOptions();
					return new ChromeDriver(chromeOptions);
				case Enums.BrowserType.Firefox:
					return new FirefoxDriver();
				default:
					throw new ArgumentException($"Unknown argument value {browserType}", nameof(browserType));
			}
		}

		[OneTimeSetUp]
		public void Prepare()
		{
			//Driver = InitializeDriver(Enums.BrowserType.Chrome);
		}

		[SetUp]
		public void Setup()
		{
			Driver = InitializeDriver(Enums.BrowserType.Chrome);
			Driver.Navigate().GoToUrl("http://www.leafground.com/");
			Driver.Manage().Window.Maximize();
		}

		[TearDown]
		public void Close()
		{
			Driver.Quit();
		}

		[OneTimeTearDown]
		public  void Clean()
		{
			Driver.Quit();
		}
	}
}
