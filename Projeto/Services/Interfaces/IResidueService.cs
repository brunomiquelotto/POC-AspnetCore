using System.Collections.Generic;
using System.Threading.Tasks;
using Db;
using Domain;

namespace Projeto.Services.Interfaces
{
    public interface IResidueService
    {
        Task SaveAsync(ResidueDto residue);
        Task<ResidueDto> GetAsync(int id);
        Task DeleteAsync(int id);
    }
}