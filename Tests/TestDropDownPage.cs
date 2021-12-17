using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Pages;
using NUnit.Framework;

namespace AutomationCourseExlrt.Tests
{
	[TestFixture]
	class TestDropdownPage : BaseTest
	{
		[Test]
		public void TestValidateDefaultValue()
		{
			DropdownPage dropdownPage = new DropdownPage(Driver);
			var result = dropdownPage.ValidateDefaultValue();
			Assert.AreEqual("Select training program using Index", result, "Returned wrong text");
		}

		[Test]
		public void TestSelectElementByText()
		{
			DropdownPage dropdownPage = new DropdownPage(Driver);
			var result = dropdownPage.SelectElementByText();
			Assert.AreEqual("1", result, "Returned wrong text");
		}

		//[Test]
		//public void TestDropdownContainsElements()
		//{
		//	DropdownPage dropdownPage = new DropdownPage(Driver);
		//	var result = dropdownPage.PrintAllOpetions();
		//	Assert.Contains("Selenium Appium", result, "Doesn't contain");
		//}
	}
}
