using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Pages;
using NUnit.Framework;

namespace AutomationCourseExlrt.Tests
{
	[TestFixture]
	class TestAletsPage : BaseTest
	{

		[Test]
		public void TestClickOnAlertBox()
		{
			AlertsPage alertsPage = new AlertsPage(Driver);
			var result = alertsPage.ClickAlertBox();
			Assert.IsTrue(result);
		}

		[Test]
		public void TestConfirmBox()
		{
			AlertsPage alertsPage = new AlertsPage(Driver);
			var result = alertsPage.ConfirmBox();
			Assert.IsTrue(result, "Alert did not accepted or appear");
		}

		[Test]
		public void TestPromptBox()
		{
			AlertsPage alertsPage = new AlertsPage(Driver);
			var results = alertsPage.PromptBox();
			Assert.IsTrue(results, "Wrong credentials");
		}

	}
}
