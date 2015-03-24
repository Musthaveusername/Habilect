using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilect.Model
{
    public class SqlRepository : IRepository
    {
        [Inject]
        public DataClassesDataContext Db { get; set; }

        public IQueryable<Course> Courses
        {
            get { throw new NotImplementedException(); }
        }

        public bool CreateCourse(Course inst)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCourse(Course inst)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCourse(Course inst)
        {
            throw new NotImplementedException();
        }

    }
}
