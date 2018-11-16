using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Projeto.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Policy = "AdminOnly")]
    public class BaseController : Controller
    {
        
    }
}