using Microsoft.Data.SqlClient;
using StudentsForms.DAL;
using StudentsForms.MODELS;
using StudentsForms.SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsForms.Forms
{
    internal partial class StudentDetailsForm : Form
    {
        DBContext dbContext;
        StudentModel Student;
        CRUDService _CRUDService;

        public StudentDetailsForm(DBContext DB, StudentModel student)
        {
            InitializeComponent();
            dbContext = DB;
            Student = student;
            _CRUDService = new CRUDService(dbContext);

            label1.Text = $"welcome {student.Name}";
            labelDebt.Text = $"היתרה לתשלום היא {student.Debt}";
            List<CoursesModel> courses = _CRUDService.GetCoursesByID(student.Id);
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = courses;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || !textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("your input not correct");
            }
            else
            {
                bool isPayment = _CRUDService.Payment(Student.Id, int.Parse(textBox1.Text));
                if (isPayment)
                {
                    MessageBox.Show("התשלום התבצע בהצלחה");
                    labelDebt.Text = $"היתרה לתשלום היא {Student.Debt - int.Parse(textBox1.Text)}";

                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            string query = "insert into StudentsINCours values (@StudentID, @CourseID)";
            SqlParameter[] parameters = {
                new SqlParameter("@StudentID", Student.Id),
                new SqlParameter("@CourseID", int.Parse(textBoxCourse.Text))
            };
            bool isInsert = dbContext.ExecuteNonQuery(query, parameters);
            if (isInsert)
            {
                string query1 = "select Price from Courses where ID = @ID";
                SqlParameter[] parameters1 = { new SqlParameter("@ID", int.Parse(textBoxCourse.Text)) };
                DataTable price = dbContext.MakeQuery(query1, parameters1);
                int price1 = (int)price.Rows[0][0];
                string query2 = "update Students set Debt = Debt + @price where ID = @ID";
                SqlParameter[] parameters2 = { new SqlParameter("@Price", price1) , new SqlParameter("@ID", Student.Id) };
                bool isUpdate = dbContext.ExecuteNonQuery(query2, parameters2);
                if (isUpdate)
                {
                    MessageBox.Show("ההרשמה בוצעה בהצלחה");
                    labelDebt.Text = $"היתרה לתשלום היא {Student.Debt + price1}";

                }
                else
                {

                    MessageBox.Show("Error"); 
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
