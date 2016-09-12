using System.Collections;
using System.Collections.Generic;

namespace Classroom.Core.Domain
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        public string Telephone { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}