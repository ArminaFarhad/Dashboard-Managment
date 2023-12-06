using DashboardManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace DashboardManagement.Repository.Context
{
    public class DashboardDbContext : DbContext
    {
        public DbSet<Dashboard> Dashboard { get; set; }
        public DbSet<Widget> Widget { get; set; }
        public DbSet<DashboardWidget> DashboardWidgets { get; set; }
    }
}
