using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Thuongmaidientu.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "ADMIN")]
    public class DashboardManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
