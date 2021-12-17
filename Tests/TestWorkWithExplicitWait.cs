using System;
using System.Collections.Generic;
using System.Text;
using AutomationCourseExlrt.Base;
using AutomationCourseExlrt.Pages;
using NUnit.Framework;

namespace AutomationCourseExlrt.Tests
{
	[TestFixture]
	class TestWaitMethodsPage : BaseTest
	{
		[Test]
		public void TestWaitMethods()
		{
			WaitMethods waitMethods = new WaitMethods(Driver);
			var result = waitMethods.PerformWaitForChange();
			Assert.True(result);
		}
	}
}
