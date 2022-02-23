using GroupsUsers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupsUsers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private ExchangeDbContext _ExchangeDbContext;
        public UsersController(ExchangeDbContext exchangeDbContext)
        {
            _ExchangeDbContext = exchangeDbContext;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<Users> Get()
        {
            return _ExchangeDbContext.Users.ToList();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public Users Get(int id)
        {
            return _ExchangeDbContext.Users.Find(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] Users users)
        {
            _ExchangeDbContext.Users.Add(users);
            _ExchangeDbContext.SaveChanges();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Users users)
        {
            Users user = _ExchangeDbContext.Users.Find(id);
            user.Email = users.Email;
            user.Name = users.Name;
            user.Password = users.Password;
            _ExchangeDbContext.Users.Add(users);
            _ExchangeDbContext.SaveChanges();

        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Users user = _ExchangeDbContext.Users.Find(id);
            _ExchangeDbContext.Users.Remove(user);
            _ExchangeDbContext.SaveChanges();
        }
    }
}
