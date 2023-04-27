using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalExam
{
    internal class FGrades
    {
        // private fields
        private double midterm;
        private double project;
        private double final;


        //public properties
        public double Midterm
        {
            get { return midterm; }
            set { midterm = value; }
        }

        public double Project
        {
            get { return project; }
            set { project = value; }
        }

        public double Final
        {
            get { return final; }
            set { final = value; }
        }

        //default constructor
        public FGrades() 
        {
            this.midterm = 0;
            this.project = 0;
            this.final = 0;
        }

        //overloading constructor
        public FGrades(double mid)
        {
            this.midterm = mid;
            this.project = 0;
            this.final = 0;
        }

        //overloading constructor
        public FGrades (double mid, double proj)
        {
            this.midterm = mid;
            this.project = proj;
            this.final = 0;
        }

        //overloading constructor
        public FGrades (double mid, double proj, double fin)
        {
            this.midterm = mid;
            this.project = proj;
            this.final = fin;
        }

        //get the percentage of midterm
        public double midterm_percentage()
        {
            return Midterm * 0.3;
        }

        //get the percentage of project
        public double project_percentage()
        {
            return Project * 0.3;
        }

        //get the percentage of final
        public double final_percentage()
        {
            return Final * 0.4;
        }

        //get the total
        public double Total()
        {
            return midterm_percentage() + project_percentage() + final_percentage();
        }

        //get the letter
        public string letter()
        {
            string letter;
            double total = Total();

            if (total >= 90 && total <= 100)
            {
                letter = "A";
            }
            else if (total >= 80 && total <= 89.9)
            {
                letter = "B";
            }
            else if (total >= 70 && total <= 79.9)
            {
                letter = "C";
            }
            else if (total >= 60 && total <= 69.9)
            {
                letter = "D";
            }
            else if (total >= 0 && total <= 59.9)
            {
                letter = "F";
            }
            else
            {
                letter = "NaG (Not a Grade)";
            }

            return letter;

        }
    }
}
