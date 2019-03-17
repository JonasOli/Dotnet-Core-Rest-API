using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restApi.Models;
using restApi.Persistence.DAO.Interfaces;

namespace restApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserDAO _userDAO;
        public UserController(IUserDAO userDAO)
        {
            _userDAO = userDAO;
        }
        
        [HttpGet("getUsers")]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userDAO.GetUsers();
        }

        [HttpGet("getUser/{id}")]
        public async Task<ActionResult<User>> GetUser(long id)
        {
            var user = await _userDAO.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost("insertUser")]
        public async Task<ActionResult> InsertUser(User user)
        {
            int result =  await _userDAO.InsertUser(user);
            
            if (result == 1)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
