using System;
using System.Collections.Generic;
using System.Linq;

namespace DryIocWebapi.Sample.Core.Repositories
{
    public class WidgetRepository : IWidgetRepository
    {
        private readonly IList<Widget> _widgets;

        public WidgetRepository()
        {
            _widgets = new List<Widget> {new Widget
            {
                Cost = new Decimal(1.99),
                Description = "First Widget",
                Name ="Widget #1"
            }};
        }

        public IEnumerable<Widget> GetWidgetQuery()
        {
            return _widgets.AsEnumerable();
        }

        public void AddWidget(Widget widget)
        {
            _widgets.Add(widget);
        }

    }
}