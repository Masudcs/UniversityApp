using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityApp.Models;
using UniversityApp.Manager;

namespace UniversityApp.UI
{
    public partial class StudentUI : System.Web.UI.Page
    {
        StudentManager aManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            studentGridView.DataSource = null;
            studentGridView.DataSource = aManager.GetAllStudent();
            studentGridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.StudentName = studentNameTextBox.Text;
            aStudent.RegNO = regNOTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.Department = departmentTextBox.Text;
            
            string message=aManager.saveStudent(aStudent);
            messageLabel.Text = message;

        }
    }
}