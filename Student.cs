using System;
using System.Collections.Generic;
using System.Text;

namespace Slotkin_PropertiesDemo1
{
    class Student
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public double AverageScore { get; private set; }
        
        private double averageScore;

        public Student(string newName, int newIdNumber)
        {
            this.Name = newName;
            this.IdNumber = newIdNumber;
        }

        private int score1;
        public int Score1
        {
            get { return score1; }
            set { score1 = value; UpdateAverageScore(); }
        }
        private int score2;

        public int Score2
        {
            get { return score2; }
            set { score2 = value; UpdateAverageScore(); }
        }

        public double HighScore
        {
            get
            {
                if (score1 > score2)
                {
                    return score1;
                }
                else
                {
                    return score2;
                }
            }
        }

        public double GetAverageScore()
        {
            return this.averageScore;
        }

        private void UpdateAverageScore()
        {
            this.averageScore = (score1 + score2) / 2;
        }
    }
}
