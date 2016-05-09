using System.Collections.Generic;
using System.Web.Http;
using DryIocWebapi.Sample.Core.Models;
using DryIocWebapi.Sample.Core.Services;

namespace DryIocWebapi.Sample.Controllers
{
    public class WidgetController : ApiController
    {
        public IWidgetService WidgetService { get; set; }

        // GET api/<controller>
        public List<WidgetSummary> Get()
        {
            return WidgetService.GetWidgetSummaries();
        }
    }
}
