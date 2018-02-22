using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; } // EntityFramework will regarded  ID or <classname>ID as primary key.
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }    
        // Using ICollection<T> is that，
        // One Student's Entity can relate to many Enrollment's Entity
        // You can specify data type too， use List<T> or HashSet<T>
        // By Default，EntityFramework use HashSet<T>

    }
}
