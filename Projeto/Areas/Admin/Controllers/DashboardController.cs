using Microsoft.AspNetCore.Mvc;

namespace Projeto.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index() => View();
    }
}