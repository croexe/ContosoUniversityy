using AutoMapper;
using ContosoUniversity.Dtos;
using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.App_Start
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            Mapper.CreateMap<Course, CourseDto>();
            Mapper.CreateMap<CourseDto, Course>();
            Mapper.CreateMap<Department, DepartmentDto>();
            Mapper.CreateMap<DepartmentDto, Department>();
            Mapper.CreateMap<Instructor, InstructorDto>();
            Mapper.CreateMap<InstructorDto, Instructor>();
            Mapper.CreateMap<OfficeAssignment, OfficeAssignmentDto>();
            Mapper.CreateMap<OfficeAssignmentDto, OfficeAssignment>();
            Mapper.CreateMap<Enrollment, EnrollmentDto>();
            Mapper.CreateMap<EnrollmentDto, Enrollment>();
            Mapper.CreateMap<Student, StudentDto>();
            Mapper.CreateMap<StudentDto, Student>();
        }

    }
}