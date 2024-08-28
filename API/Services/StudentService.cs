using API.DTOs.StudentDTOs;
using API.Entities;
using API.Interfaces;
using API.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Services;

public class StudentService : IStudentService
{
    private readonly IGenericRepository<Student> _studentRepository;
    private readonly IMapper _mapper;

    public StudentService(IGenericRepository<Student> studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<StudentDTO>> GetAllStudentsAsync()
    {
        var students = await _studentRepository.SelectAllAsync().Include(x => x.Subjects).ThenInclude(x => x.Subject)
        .ToListAsync();
        return _mapper.Map<IEnumerable<StudentDTO>>(students);
    }

    public async Task<StudentDTO> GetStudentByIdAsync(int id)
    {
        var student = await _studentRepository.SelectAllAsync().Include(x => x.Subjects).ThenInclude(x => x.Subject).FirstOrDefaultAsync(x => x.Id == id);
        return _mapper.Map<StudentDTO>(student);
    }

    public async Task<StudentDTO> CreateStudentAsync(StudentCreateDTO studentCreateDTO)
    {
        var student = _mapper.Map<Student>(studentCreateDTO);
        await _studentRepository.InsertAsync(student);
        return _mapper.Map<StudentDTO>(student);
    }

    public async Task<string> UpdateStudentAsync(int id, StudentUpdateDTO studentUpdateDTO)
    {
        var student = await _studentRepository.SelectByIdAsync(id);
        if (student == null) return "Not Found";

        _mapper.Map(studentUpdateDTO, student);
        await _studentRepository.UpdateAsync(id, student);

        return "Updated";
    }

    public async Task<string> DeleteStudentAsync(int id)
    {
        var student = await _studentRepository.SelectByIdAsync(id);
        if (student != null)
        {
            await _studentRepository.DeleteAsync(id);
            return "Deleted";
        }
        return "Not Found";
    }
}