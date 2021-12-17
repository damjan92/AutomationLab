using OpenQA.Selenium;
using System.Threading.Tasks;
using AutomationCourseExlrt.Base;
using RestSharp;
using System.Net;

namespace AutomationCourseExlrt.Pages
{
	class LinkValidationAndResponse : BasePage
	{
		public LinkValidationAndResponse(IWebDriver driver) : base( driver)
		{
			Driver = driver;
		}



		public int CheckReturnedStatusCode()
		{
			RestClient restClient = new RestClient();
			RestRequest restRequest = new RestRequest("http://www.leafground.com/pages/Image.html", Method.GET);

			IRestResponse restResponse = restClient.Execute(restRequest);

			HttpStatusCode httpStatusCode = restResponse.StatusCode;

			System.Console.WriteLine("HTTP Status Code: " + httpStatusCode);
			System.Console.WriteLine("HTTP Status Code: " + (int)httpStatusCode);

			return (int)httpStatusCode;
		}

	}

}
