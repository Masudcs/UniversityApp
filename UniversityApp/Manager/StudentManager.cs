using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityApp.Gateway;
using UniversityApp.Models;

namespace UniversityApp.Manager
{
    public class StudentManager
    {
        StudentGateway aGateWay = new StudentGateway();
        public string saveStudent(Student aStudent)
        {
            if (aStudent.StudentName == "")
            {
                return "please Enter Student name";
            }
            if (aStudent.RegNO == "")
            {
                return "please Enter Student register number";
            }
            if (aStudent.Department == "")
            {
                return "please Enter Student department name";
            }

            if (aGateWay.IsExistRegNo(aStudent.RegNO))
            {
                return "This Register number already exist";
            }
            int rowCount = aGateWay.saveStudent(aStudent);
            if (rowCount > 0)
            {
                return "Student has been saved succesfully";
            }
            else
            {
                return "Student data has not been saved";
            }
        }
        public List<Student> GetAllStudent()
        {
            return aGateWay.GetAllStudent();
        }
        public Student SearchStudentbyRegNo(string regNo)
        {
            return aGateWay.SearchStudentbyRegNo(regNo);
        }
        public string DeleteStudent(string regNo)
        {
            int rowCount = aGateWay.DeleteStudent(regNo);
            if (rowCount > 0)
            {
                return "Student has been deleted succesfully";
            }
            else
            {
                return "Student data has not been deleted";
            }
        }
        public string UpdateStudent(Student aStudent)
        {
            int rowCount = aGateWay.UpdateStudent(aStudent);
            if (rowCount > 0)
            {
                return "Student has been Updated succesfully";
            }
            else
            {
                return "Student data has not been Updated";
            }
        }
    }
}