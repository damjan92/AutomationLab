using AutomationCourseExlrt.Helpers;
using OpenQA.Selenium;
using AutomationCourseExlrt.Base;
using System.Collections;
using System.Collections.Generic;

namespace AutomationCourseExlrt.Pages
{
	class DropdownPage : BasePage
	{
		public DropdownPage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		IWebElement dropdownIcon => Driver.FindElement(By.CssSelector("a[href='pages/Dropdown.html']"));
		IWebElement FirstDropdownAllOptions => Driver.FindElement(By.CssSelector("select[id='dropdown1'] option[value='0']"));
		IWebElement secondDropdown => Driver.FindElement(By.CssSelector("select[name='dropdown2']"));
		IWebElement thirdDropdown => Driver.FindElement(By.CssSelector("#dropdown3"));
		IWebElement sumOfOption => Driver.FindElement(By.CssSelector(".dropdown"));
		IWebElement sendKeysDdm => Driver.FindElement(By.XPath("//div[5]//select[1]"));
		IWebElement dropdownOneClick => Driver.FindElement(By.XPath("//div[6]//select[1]//option[4]"));
		


		public string ValidateDefaultValue()
		{
			CustomMethods.Click(dropdownIcon);
			System.Threading.Thread.Sleep(2000);
			CustomMethods.Click(FirstDropdownAllOptions);
			return FirstDropdownAllOptions.Text;
		}

		public string SelectElementByText()
		{
			CustomMethods.Click(dropdownIcon);
			CustomMethods.SelectElementByText(secondDropdown, "Selenium");
			return CustomMethods.GetText(secondDropdown);
		}

		
	}
}
