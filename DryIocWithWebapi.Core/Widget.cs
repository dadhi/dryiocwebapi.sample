namespace DryIocWebapi.Sample.Core
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Widget
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }

        public Widget()
        {
        }
    }
}
