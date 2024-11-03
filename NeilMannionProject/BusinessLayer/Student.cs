using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class Student : Person, ICloneable
    {
        public Student()
        {

        }

        public Student(string fName, string lName, List<int> scores) : base(fName, lName)
        {
            FName = fName;
            LName = lName;
            Scores = scores;
        }

        public List<int> Scores { get; set; }

        //Loops through the list and outputs the total and score
        public double ScoreTotal()
        {
            double total = 0;
            foreach (int score in Scores)
            {
                total += score;
            }
            return total;
        }

        //Takes in the score and divides by the count in the list
        public double ScoreAverage()
        {
            if (Scores.Count == 0)
            {
                return 0;
            }

            double total = ScoreTotal();
            return total / Scores.Count;
        }

        //Override for the string method
        public override string? ToString()
        {
            string message = string.Empty;
            foreach (int score in Scores)
            {
                message += "| " + score ;
            }
            return base.ToString() + message;
        }

        //Clone that makes another
        public object Clone()
        {
            return new Student(this.FName, this.LName, this.Scores.ConvertAll(score => score));
            //Clone for a List does not have an option to return. You need to make a new list when cancelled.
        }
    }
}
