using System;
using CRUD.Db.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUD.Db;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DBContext db;
      
        public UserController()
        {

            db = new DBContext();

        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            try
            {
                db.Users.Add(model);
                db.SaveChanges();

                return StatusCode(StatusCodes.Status201Created);
            }

            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,ex);

            }

        }

        // PUT: api/User/5
     
    }
}
