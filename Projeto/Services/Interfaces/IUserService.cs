using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Projeto.Services.Interfaces
{
    public interface IUserService
    {
        Task<IList<IdentityUser>> GetAdmins();
    }
}