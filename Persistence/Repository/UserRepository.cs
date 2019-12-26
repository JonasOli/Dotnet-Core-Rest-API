using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using restApi.Models;
using restApi.Persistence.DAO.Interfaces;

namespace restApi.Persistence.DAO
{
    public class UserRepository : IUserRepository
    {
        private readonly AppContext _context;

        public UserRepository(AppContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUser(long id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task InsertUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(long id)
        {
            var user = await _context.Users.FindAsync(id);

            _context.Users.Remove(user);
        }
    }
}