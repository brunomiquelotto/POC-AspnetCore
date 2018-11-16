using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Db;
using Projeto.Services.Interfaces;
using Projeto.Services;

namespace Projeto.Controllers
{
    public class ResidueController : BaseController
    {
        private readonly IResidueService _residueService;
        private readonly PaginationService _paginationService;

        public ResidueController(IResidueService residueService, PaginationService paginationService)
        {
            this._residueService = residueService;
            this._paginationService = paginationService;
        }

        public IActionResult Index(int page = 1)
        {
            IList<Residue> residues = _paginationService.Get<Residue, string>(page, residue => residue.ResidueName);
            return View(residues);
        }

        [HttpGet]
        public IActionResult Create() => View();
        
        [HttpPost]
        public async Task<IActionResult> Create(Residue residue)
        {
            await _residueService.SaveAsync(residue);
            return RedirectToAction("Index");
        }
    }
}