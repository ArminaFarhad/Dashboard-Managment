using DashboardManagement.Models;
using DashboardManagement.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DashboardManagement.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository _dashboardRepository;

        public DashboardController(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }

        public async Task<List<Dashboard>> GetDashboardAsync()
        {
            return await _dashboardRepository.GetDashboardAsync();
        }

        public async Task<Widget> GetWidgetAsync(int Id)
        {
            return await _dashboardRepository.GetWidgetAsync(Id);
        }

        public async Task<List<Widget>> GetWidgetsAsync()
        {
            return await _dashboardRepository.GetWidgetsAsync();
        }

        public async Task<List<DashboardWidget>> GetDashboardWidgetAsync(int DashboardId)
        {
            return await _dashboardRepository.GetDashboardWidgetAsync(DashboardId);
        }

        public async Task SaveDashboardAsync(List<DashboardWidget> widgets)
        {
            await _dashboardRepository.SaveDashboardAsync(widgets);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
