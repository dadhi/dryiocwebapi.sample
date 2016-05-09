using System.Collections.Generic;
using DryIocWebapi.Sample.Core.Models;

namespace DryIocWebapi.Sample.Core.Services
{

    public interface IWidgetService
    {
        List<WidgetSummary> GetWidgetSummaries();
    }
}

