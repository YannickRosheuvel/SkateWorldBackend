using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedSkateWorld.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Paswword { get; set; }
        public string Email { get; set; }
        public double Xp { get; set; }
        public int Level { get; set; }
        public string Rank { get; set; }

        public virtual Course Course { get; set; }

        public User()
        {
            Rank = "Noob";
        }
    }
}
