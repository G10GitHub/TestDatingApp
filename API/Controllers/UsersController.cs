using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class UsersController(DataContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> Get()
        {
            var  users = await context.Users.ToListAsync();
            
            if (users == null || !users.Any())
            {
                return NotFound(); // Return 404 if no users are found
            }
            return Ok(users);
        }
        [HttpGet("{id:int}")]  //api/users/3
        public async Task<ActionResult<AppUser>> GetUserById(int id)
        {
            var  user = await context.Users.FindAsync(id);

            if(user==null)
            return NotFound();
            
            return Ok(user);
        }
    }
}