using AutomationCourseExlrt.Pages;
using NUnit.Framework;
using AutomationCourseExlrt.Base;

namespace AutomationCourseExlrt.Tests
{
	class TestValidationAndResponse : BaseTest
	{

		[Test]
		public void TestReturnValidCode()
		{
			LinkValidationAndResponse linkValidation = new LinkValidationAndResponse(Driver);
			var result = linkValidation.CheckReturnedStatusCode();

			Assert.AreEqual(200, result, "Returned wrong code");
		}

		[Test]
		public void TestReturnedInvalidCode401()
		{
			LinkValidationAndResponse linkValidation = new LinkValidationAndResponse(Driver);
			var result = linkValidation.CheckReturnedStatusCode();

			Assert.AreNotEqual(401, result, "Returned wrong code");
		}
		[Test]

		public void TestReturnedInvalidCode404()
		{
			LinkValidationAndResponse linkValidation = new LinkValidationAndResponse(Driver);
			var result = linkValidation.CheckReturnedStatusCode();

			Assert.AreNotEqual(404, result, "Returned wrong code");
		}

	}
}
