using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Services.Interfaces;
using Projeto.Services;
using System.Linq;

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
                .Transform<IList<Domain.Residue>>(residueList => residueList.Select(residue => new Domain.Residue() { Id = residue.ResidueId, Name = residue.ResidueName }))
                .Get();

            return View(residues);
        }

        [HttpGet]
        public IActionResult Create() => View();
        
        [HttpPost]
        public async Task<IActionResult> Create(Domain.Residue model)
        {
            //TODO: Automapper
            Db.Residue residue = new Db.Residue()
            {
                ResidueName = model.Name
            };
            await _residueService.SaveAsync(residue);
            return RedirectToAction("Index");
        }
    }
}