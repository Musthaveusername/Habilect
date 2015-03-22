using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Habilect.Models
{
    public class Course
    {
        public Course()
        {
            Motions = new HashSet<Motion>();
        }

        public int Id { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public List<int> MotionsId { get; set; }

        public ICollection<Motion> Motions { get; set; }
    }


}