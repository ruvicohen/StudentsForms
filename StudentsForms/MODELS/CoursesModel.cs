using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsForms.MODELS
{
    internal class CoursesModel
    {
        public int ID { get; set; }
        public string NameCourse { get; set; }
        public int CycleCourse { get; set; }
        public DateTime StartCourse { get; set; }
        public DateTime EndCourse { get; set; }
        public int Price { get; set; }
        public string DaysAndHours { get; set; }

        public CoursesModel(int iD, string nameCourse, int cycleCourse, DateTime startCourse, DateTime endCourse, int price, string daysAndHours)
        {
            ID = iD;
            NameCourse = nameCourse;
            CycleCourse = cycleCourse;
            StartCourse = startCourse;
            EndCourse = endCourse;
            Price = price;
            DaysAndHours = daysAndHours;
        }
    }
}
