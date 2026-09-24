using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCal
{
    public class EstimatedAssignment : Assignment
    {
        public EstimatedAssignment(string name, double possiblePoints, double estimatedPoints)
            : base(name, possiblePoints)
        {
            this.estimatedPoints = estimatedPoints;
        }

        private double estimatedPoints;

        public double EstimatedPoints
        {
            get { return estimatedPoints; }
            set { estimatedPoints = value; }
        }

        public override double GetPointsForCalculation()
        {
            return estimatedPoints;
        }

        public override string GetStatus()
        {
            return "Estimated";
        }
    }
}
