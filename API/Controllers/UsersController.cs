using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Collections.Generic;
using API.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext  context)
        {
            _context = context;
            
        }
        // api / users /3
        [HttpGet]
         public  async Task<ActionResult<IEnumerable<AppUser>>>GetUsers()
         {
             return await  _context.Users.ToListAsync();
           
         }

         [HttpGet("{id}")]
         public  async Task<ActionResult<AppUser>>GetUsers(int id )
         {
             return await  _context.Users.FindAsync(id);
          
         }
    }
}