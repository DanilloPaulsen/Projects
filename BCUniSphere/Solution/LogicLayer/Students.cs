using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCUniSphere.LogicLayer
{
    internal class Students
    {

        public class Student
        {
            public Student(int studentNumber, string name, string surname, byte[] studentImage, DateTime dateOfBirth, string gender, string phone, string address, int courseId)
            {
                StudentNumber = studentNumber;
                Name = name;
                Surname = surname;
                StudentImage = studentImage;
                DateOfBirth = dateOfBirth;
                Gender = gender;
                Phone = phone;
                Address = address;
                CourseID = courseId;
            }

            public int StudentNumber { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public byte[] StudentImage { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CourseID { get; set; }
            public Student() 
            {

            }
        }
    }
}
