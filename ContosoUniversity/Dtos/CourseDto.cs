﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Dtos
{
    public class CourseDto
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public virtual DepartmentDto DepartmentDto { get; set; }
        public virtual ICollection<EnrollmentDto> EnrollmentsDto { get; set; }
        public virtual ICollection<InstructorDto> InstructorsDto { get; set; }

    }
}