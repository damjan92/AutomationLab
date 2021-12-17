using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Pages;
using NUnit.Framework;

namespace AutomationCourseExlrt.Tests
{
	[TestFixture]
	class TestIframePage : BaseTest
	{
		[Test]
		public void TestFirstButtonOfIframe()
		{
			IFramePage framePage = new IFramePage(Driver);
			var result = framePage.IframeClick();
			Assert.IsTrue(result);
		}

		[Test]
		public void TestSecondButtonOfIframeClick()
		{
			IFramePage framePage = new IFramePage(Driver);
			var result = framePage.SecondIframeClick();
			Assert.IsTrue(result);
		}

		
	}
}
