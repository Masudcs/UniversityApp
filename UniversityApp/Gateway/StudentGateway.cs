using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using UniversityApp.Models;
namespace UniversityApp.Gateway
{
    public class StudentGateway
    {
        public int saveStudent(Student astudent) 
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-M780AK3\SQLEXPRESS;Initial Catalog=University16;Integrated Security=True");
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-M780AK3\\SQLEXPRESS;Initial Catalog=University16;Integrated Security=true;");
            connection.Open();
            string querry = "INSERT INTO Student_tb(StudentName,RegNo,Email,Address,Department)VALUES('" + astudent.StudentName + "','" + astudent.RegNO + "','" + astudent.Email + "','" + astudent.Address + "','" + astudent.Department + "')";
            SqlCommand cmd = new SqlCommand(querry, connection);
            int rowCount = cmd.ExecuteNonQuery();
            connection.Close();
            return rowCount;
        }
        public bool IsExistRegNo( string regNo)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-M780AK3\SQLEXPRESS;Initial Catalog=University16;Integrated Security=True");
            connection.Open();
            string querry = "SELECT * FROM Student_tb Where RegNo='"+regNo+"'";
            SqlCommand cmd = new SqlCommand(querry, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else return false;

        }
        public List<Student> GetAllStudent()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-M780AK3\SQLEXPRESS;Initial Catalog=University16;Integrated Security=True");
            connection.Open();
            string querry = "SELECT * FROM Student_tb";
            SqlCommand cmd = new SqlCommand(querry, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student aStudent = new Student();
                aStudent.StudentId =Convert.ToInt32(reader["Id"].ToString());
                aStudent.StudentName = reader["StudentName"].ToString();
                aStudent.RegNO = reader["RegNo"].ToString();
                aStudent.Address = reader["Address"].ToString();
                aStudent.Department = reader["Department"].ToString();
                students.Add(aStudent);
            }
            connection.Close();
            return students;
        }
        public Student SearchStudentbyRegNo(string regNo)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-M780AK3\SQLEXPRESS;Initial Catalog=University16;Integrated Security=True");
            connection.Open();
            string querry = "SELECT * FROM Student_tb Where RegNo='"+regNo+"'";
            SqlCommand cmd = new SqlCommand(querry, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            Student aStudent = new Student();
            while (reader.Read())
            {
                
                aStudent.StudentId = Convert.ToInt32(reader["Id"].ToString());
                aStudent.StudentName = reader["StudentName"].ToString();
                aStudent.RegNO = reader["RegNo"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Address = reader["Address"].ToString();
                aStudent.Department = reader["Department"].ToString();
            }
            connection.Close();
            return aStudent;
        }
        public int DeleteStudent(string regNo)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-M780AK3\SQLEXPRESS;Initial Catalog=University16;Integrated Security=True");
            connection.Open();
            string querry = "DELETE FROM Student_tb Where RegNo='" + regNo + "'";
            SqlCommand cmd = new SqlCommand(querry, connection);
            int rowCount = cmd.ExecuteNonQuery();
            //connection.Close();
            return rowCount;

        }
        public int UpdateStudent(Student aStudent)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-M780AK3\SQLEXPRESS;Initial Catalog=University16;Integrated Security=True");
            connection.Open();
            string querry = "Update Student_tb SET StudentName='" + aStudent.StudentName + "',Email='" + aStudent.Email+ "',Address='" + aStudent.Address + "',Department='" + aStudent.Department + "' Where RegNo='"+aStudent.RegNO+"'";
            SqlCommand cmd = new SqlCommand(querry, connection);
            int rowCount = cmd.ExecuteNonQuery();
            //connection.Close();
            return rowCount;
            
        }
    }
}