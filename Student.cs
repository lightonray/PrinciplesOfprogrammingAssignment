using System;
using System.Collections.Generic;
using System.Text;

namespace POPA1
{
    class Student : Person 
    {
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public string StudentNumber { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public int AverageScore { get; set; }
        public string FullAddress { get; set; }
        public string City { get; set; }
        public static object Count { get; internal set; }


        public override string ToString()
        {
            return ($" Student {FullName} score average is {AverageScore}\n " +
                $"Student {FullName} is living in {City}\n " +
                $"Student {FullName} address is {FullAddress}");
        }
    }
}
