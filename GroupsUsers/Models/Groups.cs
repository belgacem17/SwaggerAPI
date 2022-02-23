using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupsUsers.Models
{
    public class Groups
    {
        public Groups()
        {
            Users = new List<Users>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
