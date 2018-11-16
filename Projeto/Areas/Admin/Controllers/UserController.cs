using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Projeto.Services.Interfaces;

namespace Projeto.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }
        public async Task<IActionResult> Index()
        {
            IList<IdentityUser> users = await this._userService.GetAdmins();
            return View(users);
        }

        public IActionResult Create() => View();
    }
}