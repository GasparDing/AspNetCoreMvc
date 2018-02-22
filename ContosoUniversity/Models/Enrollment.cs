using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{

    public enum Grade
    {
        A,B,C,D,F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        // If you declare as <Navigation Property Name><Navigation Property PK name> that will be regarded as Foreign Key 
        // For example：Student's PK is "ID", so it becomes StudentID
        // You can also shorthand to <Navigation Property PK name>
        // So using the Course's PK : CourseID, instead of CourseCourseID

        public int StudentID { get; set; }
        public Grade? Grade { get; set; }   // There is a "？" after data type, it's that is can be Null

        public Course Course { get; set; }  //  Navigation Prperty 
        public Student Student { get; set; }

    }
}