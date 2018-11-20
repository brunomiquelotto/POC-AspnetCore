using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Db;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Services
{
    public class PaginationService
    {
        private const int PAGE_SIZE = 10;
        private readonly ApplicationDbContext _context;
        public PaginationService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public ServiceResponse<IList<T>> Get<T, TKey>(int page, Func<T, TKey> orderBy) where T : class
        {
            IList<T> data = _context.Set<T>().OrderBy(orderBy).Skip((page - 1) * PAGE_SIZE).Take(PAGE_SIZE).ToList();
            return new ServiceResponse<IList<T>>(data);
        }
    }
}