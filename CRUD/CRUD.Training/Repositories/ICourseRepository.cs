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

    public interface ICourseRepository : IRepository<Course, int>
    {

    }
}


