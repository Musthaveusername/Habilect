using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilect.Model
{
    public partial class SqlRepository
    {
        public IQueryable<Course> Courses
        {
            get
            {
                return Db.Courses;
            }
        }

    }
}
