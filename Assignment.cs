using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace StudentCal
{
    public abstract class Assignment
    {
        public Assignment(string name, double possiblePoints)
        {
            this.name = name;
            this.possiblePoints = possiblePoints;
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private  double possiblePoints;

        public virtual double PossiblePoints
        {
            get { return possiblePoints; }
            set { possiblePoints = value; }
        }

        public virtual double GetPointsForCalculation()
        {
            return possiblePoints;
        }

        public virtual string GetStatus()
        {
            return "Assignment";

        }
    }
}
