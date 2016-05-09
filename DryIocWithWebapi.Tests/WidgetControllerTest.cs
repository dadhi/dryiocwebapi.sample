using System.Linq;
using System.Web.Http;
using DryIocWebapi.Sample.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DryIocWebapi.Sample.Tests
{
    [TestClass]
    public class WidgetControllerTest
    {
        [TestMethod]
        public void Controller_with_property_injection()
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);

            using (var scope = config.DependencyResolver.BeginScope())
            {
                var widgetController = (WidgetController)scope.GetService(typeof(WidgetController));
                Assert.IsNotNull(widgetController.WidgetService);
                var summaries = widgetController.Get();
                Assert.IsNotNull(summaries);
                Assert.AreEqual("Widget #1", summaries.First().Name);
            }
        }
    }
}
