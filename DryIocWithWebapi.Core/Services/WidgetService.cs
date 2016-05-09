using System.Collections.Generic;
using System.Linq;
using DryIocWebapi.Sample.Core.Models;
using DryIocWebapi.Sample.Core.Repositories;

namespace DryIocWebapi.Sample.Core.Services
{
    public class WidgetService : IWidgetService
    {
        public IWidgetRepository WidgetRepository { get; set; }

        public List<WidgetSummary> GetWidgetSummaries()
        {
            return WidgetRepository.GetWidgetQuery().Select(x => new WidgetSummary
            {
                Name = x.Name,
                Description = x.Description,
                Cost =  x.Cost.ToString("F1")
            }).ToList();
        }
    }
}