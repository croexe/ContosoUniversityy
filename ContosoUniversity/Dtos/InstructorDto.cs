using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Dtos
{
    public class InstructorDto : PersonDto
    {

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        public virtual ICollection<CourseDto> CoursesDto { get; set; }
        public virtual OfficeAssignmentDto OfficeAssignmentDto { get; set; }

    }
}