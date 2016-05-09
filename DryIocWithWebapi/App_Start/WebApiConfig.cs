using System.Web.Http;
using DryIoc;
using DryIoc.WebApi;
using DryIocWebapi.Sample.Core.Repositories;
using DryIocWebapi.Sample.Core.Services;

namespace DryIocWebapi.Sample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var c = new Container()
                .With(rules => rules.With(propertiesAndFields: PropertiesAndFields.Auto))
                .WithWebApi(config, throwIfUnresolved: type => type.IsController());

            c.Register<IWidgetRepository, WidgetRepository>(Reuse.Singleton);
            c.Register<IWidgetService, WidgetService>(Reuse.Singleton);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
