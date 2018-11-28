using System.Collections.Generic;
using System.Threading.Tasks;
using Projeto.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Db;
using Domain;
using System.Linq;
using Projeto.Services.Mapping;

namespace Projeto.Services.Implementations
{
    public class ResidueService : IResidueService
    {
        private readonly ApplicationDbContext Context;
        public ResidueService(ApplicationDbContext context)
        {
            this.Context = context;
        }

        public async Task DeleteAsync(int id)
        {
            Residue residue = await Context.Residues.FindAsync(id);
            Context.Residues.Remove(residue);
            await Context.SaveChangesAsync();
        }

        public async Task<ResidueDto> GetAsync(int id)
        {
            Residue residue = await Context.Residues.FindAsync(id);
            if (residue == null) return null;
            return ResidueMapper.MapFrom(residue);
        }

        public async Task<IList<Residue>> Residues(int skip = 0, int take = 10)
        {
            return await Context.Residues.OrderBy(res => res.ResidueId).Skip(skip).Take(take).ToListAsync();
        }

        public async Task SaveAsync(ResidueDto residue)
        {
            Residue dbResidue = null;
            if (residue.Id != 0)
            {
                dbResidue = await Context.Residues.FindAsync(residue.Id);
                
                if (dbResidue == null) return;

                dbResidue.ResidueName = residue.Name;
            }
            else
            {
                Context.Residues.Add(ResidueMapper.MapFrom(residue));
            }
            await Context.SaveChangesAsync();
        }
    }
}