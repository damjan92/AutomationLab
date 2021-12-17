using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Pages;
using NUnit.Framework;

namespace AutomationCourseExlrt.Tests
{
	[TestFixture]
	class TestCheckBoxPage : BaseTest
	{
		[Test]
		public void TestSelectLng()
		{
			CheckboxPage checkboxPage = new CheckboxPage(Driver);
			var result = checkboxPage.SelecetProgrammingLanguage();
			Assert.IsTrue(result, "Did not select expected checkbox");
		}

		[Test]
		public void TestIsSelected()
		{
			CheckboxPage checkboxPage = new CheckboxPage(Driver);
			var result = checkboxPage.IsSelected();
			Assert.IsTrue(result, "Did not select expected checkbox");
		}

		[Test]
		public void TestDeselect()
		{
			CheckboxPage checkboxPage = new CheckboxPage(Driver);
			var result = checkboxPage.Deselect();
			Assert.IsTrue(result, "Did not select expected checkbox");
		}
	}
}
