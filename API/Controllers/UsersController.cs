using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers(int id )
        {
          var users = _context.Users.ToList();
          return users; 
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id )
        {
          var users = _context.Users.Find(id);
          return users; 
        }
    }
}