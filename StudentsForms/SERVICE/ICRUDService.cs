using StudentsForms.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsForms.SERVICE
{
    internal interface ICRUDService
    {
        List<CoursesModel> GetCourses();
        bool SendDetailsForInterested(InterestedModel interested);
        StudentModel Login(string name, int ID);
        List<CoursesModel> GetCoursesByID(int id);

        int GetDebtByID(int id);
        bool Payment(int id, int sum);
        string GetDaysOfCours(int id);
    }
}
