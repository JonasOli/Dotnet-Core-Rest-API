using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restApi.Models;
using restApi.Persistence.DAO.Interfaces;

namespace restApi.Persistence.DAO
{
    public class UserDAO : IUserDAO
    {
        private readonly AppContext _context;

        public UserDAO(AppContext context)
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
        public async Task<int> InsertUser(User user)
        {
            _context.Users.Add(user);
            return await _context.SaveChangesAsync();
        }
    }
}