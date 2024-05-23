using CRUD.Data;
using CRUD.Training.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Training.UnitOfWork
{
   
        public interface ITrainingUnitOfWork : IUnitOfWork
        {
            ICourseRepository Courses { get; }
          
        }
    
}
