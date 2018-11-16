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
        private readonly IResidueService ResidueService;
        private readonly PaginationService paginationService;
        public ResidueController(IResidueService residueService, PaginationService paginationService)
        {
            this.ResidueService = residueService;
            this.paginationService = paginationService;
        }

        public IActionResult Index(int page = 1)
        {
            IList<Residue> residues = this.paginationService.Get<Residue, string>(page, residue => residue.ResidueName);
            return View(residues);
        }
    }
}