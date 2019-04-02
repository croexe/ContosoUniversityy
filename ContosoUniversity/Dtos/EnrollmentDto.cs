using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Dtos
{

    public enum Grade
    {
        A, B, C, D, F
    }

    public class EnrollmentDto
    {

        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public CourseDto CourseDto { get; set; }
        public StudentDto StudentDto { get; set; }

    }
}