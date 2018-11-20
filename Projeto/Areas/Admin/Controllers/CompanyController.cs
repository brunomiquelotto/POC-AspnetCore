using System.Collections.Generic;
using Db;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projeto.Services;
using Projeto.Services.Mapping;

namespace Projeto.Areas.Admin.Controllers
{
    public class CompanyController : BaseController
    {
        public PaginationService _paginationService { get; }
        public CompanyController(PaginationService paginationService)
        {
            this._paginationService = paginationService;
        }

        public IActionResult Index(int page = 1)
        {
            IList<Domain.Company> companies = 
                _paginationService
                .Get<Company, string>(page, company => company.Name)
                .Transform(CompanyMapper.MapFrom)
                .Value();
            return View(companies);
        }
    }
}