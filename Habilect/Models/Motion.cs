using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Habilect.Models
{
    public class Motion
    {
        public Motion()
        {
            Attempts = new HashSet<Attempts>();
        }

        public int Id { get; set; } 
        public int StartAngle { get; set; }
        public int EndAngle { get; set; }
        public bool CheckSpinalBalance { get; set; }
        public bool CheckShoulderBalance { get; set; }
        public int ShoulderDeviation { get; set; }
        public int PlaneDeviation { get; set; }
        public int SpinalDeviation { get; set; }
        public int MotionTemplateId { get; set; }
        public int RequiredCount { get; set; }

        public ICollection<Attempts> Attempts { get; set; }
    }
}