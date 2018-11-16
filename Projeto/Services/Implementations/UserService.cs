using System.Collections.Generic;
using System.Threading.Tasks;
using Db;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Projeto.Services.Interfaces;

namespace Projeto.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext Context;
        public UserService(ApplicationDbContext context)
        {
            this.Context = context;
        }
        public async Task<IList<IdentityUser>> GetAdmins()
        {
            return await this.Context.Users.ToListAsync();
        }
    }
}