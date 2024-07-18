using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsForms.MODELS
{
    internal class InterestedModel
    {
        public string Name { get; set; }
        public int Phone {  get; set; }
        public int CourseID { get; set; }

        public InterestedModel(string name, int phone, int courseID)
        {
            Name = name;
            Phone = phone;
            CourseID = courseID;
        }
    }
}
