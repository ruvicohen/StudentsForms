using Microsoft.Data.SqlClient;
using StudentsForms.DAL;
using StudentsForms.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsForms.SERVICE
{
    internal class CRUDService : ICRUDService
    {
        private readonly DBContext _dbContext;

        public CRUDService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<CoursesModel> GetCourses()
        {
            List<CoursesModel> Courses= new List<CoursesModel>();
            string query = "select * from Courses";
            DataTable Courses1 = _dbContext.MakeQuery(query, null);
            foreach (DataRow row in Courses1.Rows)
            {
                if (row["ID"] != DBNull.Value && row["Name"] != DBNull.Value)
                {
                    string DayOfCourse = GetDaysOfCours((int)row[ "ID"]);
                    Courses.Add(new CoursesModel((int)row["ID"], row[1].ToString(), (int)row["Cycle"],
                        (DateTime)row["StartDate"], (DateTime)row["EndDate"],
                        (int)row["Price"], DayOfCourse));
                }
            }
            return Courses;
        }

        public List<CoursesModel> GetCoursesByID(int id)
        {
            List<CoursesModel> Courses = new List<CoursesModel>();
            string query = "select * from Courses c join StudentsINCours s on s.CoursID = c.ID where s.StudentID = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };

            DataTable Courses1 = _dbContext.MakeQuery(query, parameters);
            foreach (DataRow row in Courses1.Rows)
            {
                if (row["ID"] != DBNull.Value && row["Name"] != DBNull.Value)
                {
                    string DayOfCourse = GetDaysOfCours((int)row["ID"]);
                    Courses.Add(new CoursesModel((int)row["ID"], row[1].ToString(), (int)row["Cycle"],
                        (DateTime)row["StartDate"], (DateTime)row["EndDate"],
                        (int)row["Price"], DayOfCourse));
                }
            }
            return Courses;
        }

        public string GetDaysOfCours(int id)
        {
            StringBuilder stringOfDays = new ("");
            string query = "select * from Days d join Courses c on c.ID = d.CoursId where c.ID = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };
            DataTable Days = _dbContext.MakeQuery(query, parameters);
            foreach (DataRow row in Days.Rows)
            {
                stringOfDays.Append($"{row[1]} from {row[2]} to {row[3]};");
            }

            return stringOfDays.ToString();
        }

        public int GetDebtByID(int id)
        {
            throw new NotImplementedException();
        }

        public StudentModel Login(string name, int TZ)
        {
            string query = "select * from Students where Name = @name and TZ = @TZ";
            SqlParameter[] parameters = { new SqlParameter("@name", name),
                            new SqlParameter("@TZ", TZ)};
            DataTable student = _dbContext.MakeQuery(query,parameters);
            try
            {
                if (student.Rows.Count > 0)
                {
                    StudentModel student1;
                    student1 = new((int)student.Rows[0]["ID"], student.Rows[0]["Name"].ToString(), (int)student.Rows[0]["TZ"], (int)student.Rows[0]["Debt"]);
                    return student1;

                }

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            return null;


        }

        public bool Payment(int id, int sum)
        {
            try
            {
                string query = "insert into Payments values ( @Sum, @ID)";
                SqlParameter[] parameters = { new SqlParameter("ID", id), new SqlParameter("Sum", sum) };
                bool isPayment = _dbContext.ExecuteNonQuery(query, parameters);
                if (isPayment)
                {
                    string query1 = "update Students set Debt = Debt - @sum where ID = @ID";
                    SqlParameter[] parameters1 = { new SqlParameter("ID", id), new SqlParameter("Sum", sum) };
                    bool isUpdate = _dbContext.ExecuteNonQuery(query1, parameters1);
                    if (isUpdate)
                    {
                        return true;
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            return false;


            }

            public bool SendDetailsForInterested(InterestedModel interested)
        {
            try
            {
                string query = "insert into Intersted values(@Name, @Phone,@CourseID)";
                SqlParameter[] parameters = { new SqlParameter("@Name", interested.Name),
                                          new SqlParameter("@Phone", interested.Phone),
                                          new SqlParameter("@CourseID", interested.CourseID)};
                bool isExsist = _dbContext.ExecuteNonQuery(query, parameters);
                if (isExsist)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;

        }
    }
}
