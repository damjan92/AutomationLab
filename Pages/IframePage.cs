using System.Collections.Generic;
using AutomationCourseExlrt.Helpers;
using OpenQA.Selenium;
using AutomationCourseExlrt.Base;

namespace AutomationCourseExlrt.Pages
{
	class IFramePage : BasePage
	{
		IWebElement IframeClk => Driver.FindElement(By.CssSelector("a[href='pages/frame.html']"));
		IWebElement FirstFrame => Driver.FindElement(By.XPath("//iframe[@src='default.html']"));
		IWebElement FrameClick => Driver.FindElement(By.CssSelector("#Click"));
		IWebElement SecondFrame => Driver.FindElement(By.XPath("//iframe[@src='page.html']"));
		IWebElement NestedFrame => Driver.FindElement(By.XPath("//iframe[@id='frame2']"));
		IList<IWebElement> IframesList => Driver.FindElements(By.XPath("//iframe"));
		IWebElement SecondFrClk => Driver.FindElement(By.CssSelector("#Click1"));


		public IFramePage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		public bool IframeClick()
		{
			CustomMethods.Click(IframeClk);
			Driver.SwitchTo().Frame(FirstFrame);
			CustomMethods.Click(FrameClick);
			if (FrameClick.Text.Contains("Clicked"))
			{
				LogUtil.Log("You clicked the button");
				//Driver.SwitchTo().DefaultContent();
				return true;
			}
			else
			{
				LogUtil.Log("You missed the frame");
				Driver.SwitchTo().DefaultContent();
				return false;
			}
		}

		public bool SecondIframeClick()
		{
			CustomMethods.Click(IframeClk);
			Driver.SwitchTo().Frame(SecondFrame);
			Driver.SwitchTo().Frame(NestedFrame);
			CustomMethods.Click(SecondFrClk);
			if (SecondFrClk.Text.Contains("Clicked"))
			{
				LogUtil.Log("You clicked the button");
				Driver.SwitchTo().DefaultContent();
				return true;
			}
			else
			{
				LogUtil.Log("You missed the frame");
				Driver.SwitchTo().DefaultContent();
				return false;
			}
		}

	}
}
