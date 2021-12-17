using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Pages;
using NUnit.Framework;

namespace AutomationCourseExlrt.Tests
{
	[TestFixture]
	class TestWindowPage : BaseTest
	{
		[Test]
		public  void TestURLofNewWindow()
		{
			WindowPage windowPage = new WindowPage(Driver);
			var result = windowPage.CheckNewWindowHp();
			Assert.AreEqual("TestLeaf - Interact with Windows", result.TitleOfnewWindow, "Title doesnt match");
		}

		[Test]
		public void TestNumberOfOpenedWindow()
		{
			WindowPage windowPage = new WindowPage(Driver);
			var result = windowPage.CountNumOfWindow();
			Assert.AreEqual(4, result, "Number is not the same");
		}
	}
	
}
