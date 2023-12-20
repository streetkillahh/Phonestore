using Microsoft.EntityFrameworkCore;
using Phonestore.DAL.Interfaces;
using Phonestore.Domain.Entity.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonestore.DAL.Repositories
{
    public class UserRepository : IBaseRepository<User>
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext context) => _db = context;
        public async Task Create(User entity)
        {
            await _db.Users.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<User> GetAll() => _db.Users;
    }
}
