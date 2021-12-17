using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Helpers;

namespace AutomationCourseExlrt.Pages
{
	class CheckboxPage : BasePage
	{
		public CheckboxPage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		
		IWebElement clickCheckbox => Driver.FindElement(By.XPath("//a[@href='pages/checkbox.html']"));
		IWebElement selectJava => Driver.FindElement(By.XPath
			("//div[normalize-space()='C++']//input[@type='checkbox']"));
		IWebElement selectVB => Driver.FindElement(By.XPath
			("//div[normalize-space()='VB']//input[@type='checkbox']"));
		IWebElement IsSeleneiumSlctd => Driver.FindElement(By.XPath
			("//div[normalize-space()='Selenium']//input[@type='checkbox']"));
		IWebElement deselectCb => Driver.FindElement(By.XPath
			("//div[normalize-space()='I am Selected']//input[@type='checkbox']"));
		IWebElement optionOne => Driver.FindElement(By.XPath
			("//div[normalize-space()='Option 1']//input[@type='checkbox']"));


		public bool SelecetProgrammingLanguage()
		{
			CustomMethods.Click(clickCheckbox);
			CustomMethods.Click(selectJava);
			CustomMethods.Click(selectVB);
			if (selectVB.Selected == true && selectJava.Selected == true)
			{
				LogUtil.Log("Languages are selected");
				return true;
			}
			else
			{
				LogUtil.Log("Checkbox is not selected");
				return false;
			}
		}

		public bool IsSelected()
		{
			CustomMethods.Click(clickCheckbox);
			if (IsSeleneiumSlctd.Selected == true)
			{
				LogUtil.Log("Checkbox is selected");
				return true;
			}
			else
			{
				LogUtil.Log("Checkbox is not selected");
				return false;
			}
		}

		public bool Deselect()
		{
			CustomMethods.Click(clickCheckbox);
			if (deselectCb.Selected == true)
			{
				LogUtil.Log("Checkbox is already selected");
				return true;
			}
			else
			{
				LogUtil.Log("Checkbox is not selected, Click!");
				CustomMethods.Click(deselectCb);
				return false;
			}
		}

		
	}
}
