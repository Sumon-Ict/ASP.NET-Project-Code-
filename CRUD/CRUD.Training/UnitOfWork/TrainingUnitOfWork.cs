using CRUD.Models;
using CRUD.Training.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Data;

namespace CRUD.Training.UnitOfWork
{
    public class TrainingUnitOfWork : IUnitOfWork
    {
       
        public ICourseRepository Courses { get; private set; }

        public TrainingUnitOfWork(TrainingContext context,
            ICourseRepository courses
            ) : base((DbContext)context)
        {
          
            Courses = courses;
        }



    }
}
