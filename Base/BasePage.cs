using OpenQA.Selenium;


namespace AutomationCourseExlrt.Base
{
	public class BasePage
	{
		public static IWebDriver Driver;

		public BasePage(IWebDriver driver)
		{
			Driver = driver;
		}

	}
}
