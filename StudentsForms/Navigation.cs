using StudentsForms.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsForms.Forms;
using StudentsForms.MODELS;
using System.Runtime.CompilerServices;

namespace StudentsForms
{
    internal static class Navigation
    {
        public static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form item in openForms)
            {
                
                    item.Hide();
            }
        }
        public static void ShowForms<T>(string formName, DBContext DB, StudentModel _studentModel = null)
        {
            CloseAllForms();
            Form form = formName switch
            {
                "HomePageForm" => new HomePageForm(DB),
                "StudentDetailsForm" => new StudentDetailsForm(DB, _studentModel),
                _ => throw new ArgumentException("invalid form name.", nameof(formName)),
            };
            form.Show();




        }
    }
}
