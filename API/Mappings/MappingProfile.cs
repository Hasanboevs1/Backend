using API.DTOs.StudentDTOs;
using API.DTOs.SubjectDTOs;
using API.DTOs.TeacherDTOs;
using API.Entities;
using AutoMapper;

namespace API.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Student, StudentDTO>().ReverseMap();
        //CreateMap<StudentCreateDTO, Student>().ReverseMap();
        //CreateMap<StudentUpdateDTO, Student>().ReverseMap();
        CreateMap<Student, StudentCreateDTO>().ReverseMap();
        CreateMap<Student, StudentUpdateDTO>().ReverseMap();
        CreateMap<StudentSubject, StudentSubjectDTO>()
            .ForMember(dest => dest.SubjectName, opt => opt.MapFrom(src => src.Subject.Name));

        
        CreateMap<Teacher, TeacherDTO>().ReverseMap();
        CreateMap<TeacherCreateDTO, Teacher>();
        CreateMap<TeacherUpdateDTO, Teacher>();
        CreateMap<TeacherSubject, TeacherSubjectDTO>()
            .ForMember(dest => dest.SubjectName, opt => opt.MapFrom(src => src.Subject.Name));
        

        CreateMap<Subject, SubjectDTO>().ReverseMap();
        CreateMap<SubjectCreateDTO, Subject>();
        CreateMap<SubjectUpdateDTO, Subject>();

    }
}