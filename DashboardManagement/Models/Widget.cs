using DashboardManagement.Enums;

namespace DashboardManagement.Models
{
    public class Widget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WidgetType WidgetType { get; set; }
    }
}
