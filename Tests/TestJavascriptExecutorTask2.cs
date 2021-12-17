using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Pages;
using NUnit.Framework;

namespace AutomationCourseExlrt.Tests
{
	[TestFixture]
	class TestJavascriptExecutorTask2 : BaseTest
	{

		[Test]
		public void TestJSCreateBorder()
		{
			JavascriptExecutorTask2 executorTask2 = new JavascriptExecutorTask2(Driver);
			executorTask2.JSCreateBorderDropdown();
		}

		

	}
}
