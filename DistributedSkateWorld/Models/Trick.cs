using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedSkateWorld.Models
{
    public class Trick
    {
        [Key]
        public int Id { get; set; }
        public string VideoPath { get; set; }
        public string TrickName { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        public virtual Course IdNavigation { get; set; }
    }
}
