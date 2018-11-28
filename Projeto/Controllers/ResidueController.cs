using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Services.Interfaces;
using Projeto.Services;
using System.Linq;
using Projeto.Services.Mapping;
using Domain;
using Db;

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
            IList<Domain.ResidueDto> residues = 
                _paginationService
                .Get<Residue, string>(page, residue => residue.ResidueName)
                .Transform(ResidueMapper.MapFrom)
                .Value();
            return View(residues);
        }

        [HttpGet]
        public IActionResult Create() => View();
        
        [HttpPost]
        public async Task<IActionResult> Save(ResidueDto model)
        {
            await _residueService.SaveAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            ResidueDto model = await _residueService.GetAsync(id);
            return View("Create", model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _residueService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}