using StudentsForms.DAL;
using StudentsForms.MODELS;
using StudentsForms.SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsForms.Forms
{
    internal partial class HomePageForm : Form
    {
        DBContext dbContext;
        ICRUDService _CRUDService;
        //Navigation navigationService = new Navigation();
        public HomePageForm(DBContext DB)
        {
            InitializeComponent();
            dbContext = DB;
            _CRUDService = new CRUDService(dbContext);
            List<CoursesModel> courses = _CRUDService.GetCourses();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = courses;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameStudent.Text) ||
                string.IsNullOrEmpty(textBoxTZ.Text) ||
                !textBoxTZ.Text.All(char.IsDigit))
            { MessageBox.Show("your input not correct"); }
            else
            {
                string name = textBoxNameStudent.Text;
                int TZ = int.Parse(textBoxTZ.Text); 
                StudentModel student = _CRUDService.Login(name, TZ);
                if (student != null)
                {
                    Navigation.ShowForms<string>("StudentDetailsForm", dbContext, student);
                }
                else
                {
                    MessageBox.Show("Error");
                }


            }
        }

        private void buttonSaveDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameInterested.Text) ||
                string.IsNullOrEmpty(textBoxPhone.Text) || !(textBoxPhone.Text.All(char.IsDigit))
                || string.IsNullOrEmpty(textBoxCourseID.Text) || !(textBoxCourseID.Text.All(char.IsDigit)))
                { MessageBox.Show("your input not correct"); }
            else {
                string name = textBoxNameInterested.Text;
                int phone = int.Parse(textBoxPhone.Text);
                int courseID = int.Parse(textBoxCourseID.Text);
                InterestedModel interested = new(name, phone, courseID);
                bool isSend = _CRUDService.SendDetailsForInterested(interested);
                if (isSend)
                {
                    MessageBox.Show("הפרטים נשלחו בהצלחה");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void textBoxTZ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
