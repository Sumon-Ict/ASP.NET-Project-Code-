using CRUD.Data;
using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Training.Repositories
{
    public class CourseRepository : Repository<Course, int>, ICourseRepository

    {
        public CourseRepository(TrainingContext context)
             : base((DbContext)context)
        {


        }

    }
}
