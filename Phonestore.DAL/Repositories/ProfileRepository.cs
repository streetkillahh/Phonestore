using Phonestore.DAL.Interfaces;
using Phonestore.Domain.Entity.User;

namespace Phonestore.DAL.Repositories
{
    public class ProfileRepository : IBaseRepository<Profile>
    {
        private readonly ApplicationDbContext _db;

        public ProfileRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create (Profile entity)
        {
            await _db.Profiles.AddAsync (entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Profile> GetAll()
        {
            return _db.Profiles;
        }
    }
}
