using System.Collections.Generic;

namespace DryIocWebapi.Sample.Core.Repositories
{
    public interface IWidgetRepository
    {
        IEnumerable<Widget> GetWidgetQuery();
        void AddWidget(Widget widget);
    }
}