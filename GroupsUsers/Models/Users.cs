using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupsUsers.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual Groups Groups { get; set; }
    }
}
