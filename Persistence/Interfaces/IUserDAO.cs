using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using restApi.Models;

namespace restApi.Persistence.DAO.Interfaces
{
    public interface IUserDAO
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(long id);
        Task<int> InsertUser(User user);
    }
}