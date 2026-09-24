using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StudentCal
{
    public class Student
    {
        private string studentID;
        private List<Course> courses;

        public Student(string studentID)
        {
            this.studentID = studentID;
            courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            foreach (Course course in courses) 
            {
                if (course.ClassName == name) 
                {
                    return course;
                }
            }
            return null;
        }

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }
    }
}
