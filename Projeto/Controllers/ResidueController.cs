using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Services.Interfaces;
using Projeto.Services;
using System.Linq;
using Projeto.Services.Mapping;

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
            IList<Domain.Residue> residues = 
                _paginationService
                .Get<Db.Residue, string>(page, residue => residue.ResidueName)
                .Transform(ResidueMapper.MapFrom)
                .Value();
            return View(residues);
        }

        [HttpGet]
        public IActionResult Create() => View();
        
        [HttpPost]
        public async Task<IActionResult> Create(Domain.Residue model)
        {
            Db.Residue residue = ResidueMapper.MapFrom(model);
            await _residueService.SaveAsync(residue);
            return RedirectToAction("Index");
        }
    }
}