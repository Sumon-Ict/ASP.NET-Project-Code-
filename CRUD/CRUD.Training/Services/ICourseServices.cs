using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Training.Services
{
    public interface ICourseServices
    {
        IList<Course> GetAllCourse();
        void CreateCourse(Course course);
        (IList<Course> records, int total, int totalDisplay) GetCourses(int pageIndex, int pageSize,
           string searchText, string sortText);
        Course GetCourse(int id);
        void UpdateCourse(Course course);
        void DeleteCourse(int id);
    }
}
