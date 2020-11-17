using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Data;
using Entities;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {

        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }
        
    

        // api/users/3
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser (int id)
        {
            return  _context.Users.Find(id);
        }
    }
}