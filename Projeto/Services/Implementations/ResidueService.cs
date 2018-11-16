using System.Collections.Generic;
using System.Threading.Tasks;
using Projeto.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Db;
using System.Linq;

namespace Projeto.Services.Implementations
{
    public class ResidueService : IResidueService
    {
        private readonly ApplicationDbContext Context;
        public ResidueService(ApplicationDbContext context)
        {
            this.Context = context;
        }

        public async Task<IList<Residue>> Residues(int skip = 0, int take = 10)
        {
            return await Context.Residues.OrderBy(res => res.ResidueId).Skip(skip).Take(take).ToListAsync();
        }
    }
}