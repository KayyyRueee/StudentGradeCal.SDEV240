using System;
using System.Collections.Generic;

namespace StudentCal
{
    public class Course
    {
        private string className;
        private List<Assignment> assignments;

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }

        public List<Assignment> Assignments
        {
            get { return assignments; }
            set { assignments = value; }
        }

        public Course(string name)
        {
            this.className = name;
            this.assignments = new List<Assignment>();
        }

        public void AddAssignment(Assignment a)
        {
            assignments.Add(a);
        }

        public List<Assignment> GetAssignments()
        {
            return assignments;
        }
    }
}
