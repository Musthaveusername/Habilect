using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilect.Model
{
    interface IRepository
    {
        IQueryable<Course> Courses { get; }

        bool CreateCourse(Course inst);

        bool UpdateCourse(Course inst);

        bool RemoveCourse(int CourseId);
    }
}
