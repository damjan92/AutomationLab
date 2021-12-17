using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Helpers;
using System;
using OpenQA.Selenium;

namespace AutomationCourseExlrt.Pages
{
	
	class WindowPage : BasePage
	{
		IWebElement WindowClick => Driver.FindElement(By.CssSelector("a[href='pages/Window.html']"));
		IWebElement HomePageBtn => Driver.FindElement(By.CssSelector("#home"));

		public WindowPage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}


		public NewWindowTitle CheckNewWindowHp()
		{
			CustomMethods.Click(WindowClick);

			CustomMethods.Click(HomePageBtn);
			string WindowTitle = Driver.Title;
			foreach (string item in Driver.WindowHandles)
			{
				Driver.SwitchTo().Window(item);
				Console.WriteLine("Handle: " + item + ", Title: " + Driver.Title);
			}
			Driver.Close();
			return new NewWindowTitle { TitleOfnewWindow = WindowTitle };
		}

		public int CountNumOfWindow()
		{
			CustomMethods.Click(WindowClick);

			CustomMethods.Click(HomePageBtn);
			CustomMethods.Click(HomePageBtn);
			CustomMethods.Click(HomePageBtn);

			foreach (var item in Driver.WindowHandles)
			{
				Driver.SwitchTo().Window(item);
				return Driver.WindowHandles.Count;
			}
			foreach (var item in Driver.WindowHandles)
			{
				Driver.SwitchTo().Window(item);
				Driver.Close();
			}
			Console.WriteLine("Number of windows: " + Driver.WindowHandles.Count);
			return Driver.WindowHandles.Count;
		}
	}
	public class NewWindowTitle
	{
		public string TitleOfnewWindow { get; set; }
	}
}
