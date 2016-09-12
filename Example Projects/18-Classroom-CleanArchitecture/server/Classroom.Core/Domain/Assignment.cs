using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classroom.Core.Domain
{
    public class Assignment
    {
        public int ProjectId { get; set; }
        public int StudentId { get; set; }

        public int Score { get; set; }
        public string Grade
        {
            get
            {
                if (Score == 0) return "N/A";
                if (Score > 0 && Score < 10) return "F";
                if (Score > 10 && Score < 20) return "E";
                if (Score > 20 && Score < 30) return "D";
                if (Score > 30 && Score < 40) return "C";
                if (Score > 40 && Score < 50) return "B";
                if (Score > 50 && Score < 60) return "A";

                return "A+";
            }
        }

        public virtual Project Project { get; set; }
        public virtual Student Student { get; set; }
    }
}