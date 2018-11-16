using System.Collections.Generic;
using System.Threading.Tasks;
using Db;

namespace Projeto.Services.Interfaces
{
    public interface IResidueService
    {
        Task<IList<Residue>> Residues(int skip = 0, int take = 10);
    }
}