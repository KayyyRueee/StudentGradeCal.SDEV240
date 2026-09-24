using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCal
{
    public class GradedCalculator
    {
        public GradedCalculator()
        {
        
        }

        public double CalculateCurrentGrade(List<Assignment> assignments)
        {
            double totalEarnedPoints = 0;
            double totalPossiblePoints = 0;
            foreach (Assignment assignment in assignments)
            {
                totalEarnedPoints += assignment.GetPointsForCalculation();
                totalPossiblePoints += assignment.PossiblePoints;
            }
            if (totalPossiblePoints == 0)
            {
                return 0; // Avoid division by zero
            }
            return (totalEarnedPoints / totalPossiblePoints) * 100; // Return grade as a percentage
        }

        public string DetermineLetterGrade(double grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
