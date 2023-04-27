using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace finalExam
{
    internal class Validator
    {
        public bool validateYear(string year)
        {
            Regex rgx = new Regex(@"^202[0-9]$"); //validate year between 2020-2029
            return rgx.IsMatch(year);
        }

        public bool validateSession (string session)
        {
            Regex rgx = new Regex(@"^Fall|Winter|Summer$"); //validate seasons Fall, Winter or Summer
            return rgx.IsMatch(session);
        }

        public bool validateGrades(string grades)
        {
            Regex rgx = new Regex(@"^[0-9]{1,3}$"); //validate numbers from 0-9 minimum 1 digit maximum 3
            return rgx.IsMatch(grades);
        }
    }
}
