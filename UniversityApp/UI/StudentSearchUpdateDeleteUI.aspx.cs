using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using UniversityApp.Models;
using UniversityApp.Manager;

namespace UniversityApp.UI
{
    public partial class StudentSearchUpdateDeleteUI : System.Web.UI.Page
    {
        StudentManager aManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNo = regTextBox.Text;
            Student aStudent = new Student();
            aStudent = aManager.SearchStudentbyRegNo(regNo);
            studentNameTextBox.Text = aStudent.StudentName;
            emailTextBox.Text = aStudent.Email;
            addressTextBox.Text = aStudent.Address;
            departmentTextBox.Text = aStudent.Department;
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            string regNo = regTextBox.Text;

            messageLabel.Text = aManager.DeleteStudent(regNo);
            ClearAllBoxes();

        }

        private void ClearAllBoxes()
        {
            regTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            departmentTextBox.Text = "";
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.StudentName = studentNameTextBox.Text;
            aStudent.RegNO = regTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.Department = departmentTextBox.Text;
            messageLabel.Text = aManager.UpdateStudent(aStudent);
            ClearAllBoxes();

        }
    }
}