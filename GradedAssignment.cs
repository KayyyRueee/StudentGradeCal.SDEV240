using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCal
{
    public class GradedAssignment : Assignment
    {
        public GradedAssignment(string name, double possiblePoints, double earnedPoints)
            : base(name, possiblePoints)
        {
            this.earnedPoints = earnedPoints;
        }

        private double earnedPoints;

        public double EarnedPoints
        {
            get { return earnedPoints; }
            set { earnedPoints = value; }
        }

        public override double GetPointsForCalculation()
        {
            return earnedPoints;
        }

        public override string GetStatus()
        {
            return "Graded";
        }
    }
}
