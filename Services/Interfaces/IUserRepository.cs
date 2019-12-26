using System.Collections.Generic;
using System.Threading.Tasks;
using restApi.Models;

namespace restApi.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(long id);
        Task<User> Create(User user, string password);
        Task Update(User userParam, string password = null);
        Task Delete(long id);
    }
}