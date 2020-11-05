using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedSkateWorld.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseToughness { get; set; }

        public virtual User IdNavigation { get; set; }
        public virtual Trick Trick { get; set; }
        public bool Completed { get; set; }
    }
}
