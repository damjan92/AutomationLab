using OpenQA.Selenium;
using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Helpers;

namespace AutomationCourseExlrt.Pages
{
	class AlertsPage : BasePage
	{
		public AlertsPage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		IWebElement AlertsClick => Driver.FindElement(By.CssSelector("a[href='pages/Alert.html']"));
		IWebElement AlertBoxClk => Driver.FindElement(By.CssSelector("button[onclick='normalAlert()']"));
		IWebElement AlertConfirm => Driver.FindElement(By.CssSelector("button[onclick='confirmAlert()']"));
		IWebElement resultAlert => Driver.FindElement(By.CssSelector("#result"));
		IWebElement PromtAlert => Driver.FindElement(By.CssSelector("button[onclick='confirmPrompt()']"));
		IWebElement resultPromt => Driver.FindElement(By.CssSelector("#result1"));
		IWebElement LineBreak => Driver.FindElement(By.CssSelector("button[onclick='lineBreaks()']"));
		IWebElement SweetAlert => Driver.FindElement(By.CssSelector("#btn"));



		public bool ClickAlertBox()
		{
			CustomMethods.Click(AlertsClick);
			CustomMethods.Click(AlertBoxClk);
			var alert = Driver.SwitchTo().Alert();
			alert.Accept();
			LogUtil.Log("Alert is accepted");
			return true;

		}

		public bool ConfirmBox()
		{
			CustomMethods.Click(AlertsClick);
			CustomMethods.Click(AlertConfirm);
			var alert = Driver.SwitchTo().Alert();
			alert.Dismiss();
			if (resultAlert.Displayed == true)
			{
				LogUtil.Log("You pressed Cancel");
				return true;
			}
			else
			{
				LogUtil.Log("You pressed OK");
				CustomMethods.TakeScreenshot(AlertConfirm);
				return false;
			}
		}

		public bool PromptBox()
		{
			CustomMethods.Click(AlertsClick);
			CustomMethods.Click(PromtAlert);
			var alert = Driver.SwitchTo().Alert();
			alert.SendKeys("Selenium");
			alert.Accept();
			var resultString = resultPromt.Text.Contains("Selenium");
			if (resultPromt.Text.Contains("Selenium") == true)
			{
				LogUtil.Log("Text containt Selenium");
				return resultString;
			}
			else
			{
				LogUtil.Log("You are not enjoying Testleaf");
				CustomMethods.TakeScreenshot(PromtAlert);
				return resultString;
			}
		}

	}

}
