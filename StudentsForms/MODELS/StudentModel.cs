using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsForms.MODELS
{
    internal class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TZ { get; set; }
        public int Debt { get; set; }

        public StudentModel(int id, string name, int tZ, int debt)
        {
            Id = id;
            Name = name;
            TZ = tZ;
            Debt = debt;
        }
    }
}
