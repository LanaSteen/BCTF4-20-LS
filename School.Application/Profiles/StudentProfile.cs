using AutoMapper;
using School.Domain.Models.DTOs;
using School.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Profiles
{
	public class StudentProfile : Profile
	{

		public StudentProfile()
		{
			CreateMap<Student, StudentDTO>();
			CreateMap<StudentDTO, Student>();
			CreateMap<CreateStudentDTO, StudentDTO>();
			CreateMap<CreateStudentDTO, Student>();
			CreateMap<Student, CreateStudentDTO>();
			CreateMap<Student, UpdateStudentDTO>();
			CreateMap<UpdateStudentDTO, Student>();
			//CreateMap<Student, UpdateStudentDTO>().ReverseMap();
		}
	}
}
