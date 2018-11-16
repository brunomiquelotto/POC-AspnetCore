using System.Collections.Generic;
using Db;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projeto.Services;

namespace Projeto.Areas.Admin.Controllers
{
    public class CompanyController : BaseController
    {
        public PaginationService PaginationService { get; }
        public CompanyController(PaginationService paginationService)
        {
            this.PaginationService = paginationService;
        }

        public IActionResult Index(int page = 1)
        {
            IList<Company> companies = PaginationService.Get<Company, string>(page, company => company.Name);
            return View(companies);
        }
    }
}