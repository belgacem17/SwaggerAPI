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
    public class GroupsController : ControllerBase
    {
        private ExchangeDbContext _ExchangeDbContext;
        public GroupsController(ExchangeDbContext exchangeDbContext)
        {
            _ExchangeDbContext = exchangeDbContext;
        }
        // GET: api/<GroupsController>
        [HttpGet]
        public IEnumerable<Groups> Get()
        {
            return _ExchangeDbContext.Groups.ToList();
        }

        // GET api/<GroupsController>/5
        [HttpGet("{id}")]
        public Groups Get(int id)
        {
            return _ExchangeDbContext.Groups.Find(id);
        }

        // POST api/<GroupsController>
        [HttpPost]
        public void Post([FromBody] Groups group)
        {
            _ExchangeDbContext.Groups.Add(group);
            _ExchangeDbContext.SaveChanges();
        }

        // PUT api/<GroupsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Groups group)
        {
            Groups groupdb = _ExchangeDbContext.Groups.Find(id);
            groupdb.Name = group.Name; 
            _ExchangeDbContext.Groups.Add(groupdb);
            _ExchangeDbContext.SaveChanges();
        }

        // DELETE api/<GroupsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Groups group = _ExchangeDbContext.Groups.Find(id);
            _ExchangeDbContext.Groups.Remove(group);
            _ExchangeDbContext.SaveChanges();
        }
    }
}
