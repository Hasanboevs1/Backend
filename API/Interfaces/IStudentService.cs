using API.DTOs.StudentDTOs;

namespace API.Interfaces;

public interface IStudentService
{
    Task<IEnumerable<StudentDTO>> GetAllStudentsAsync();
    Task<StudentDTO> GetStudentByIdAsync(int id);
    Task<StudentDTO> CreateStudentAsync(StudentCreateDTO studentCreateDTO);
    Task<string> UpdateStudentAsync(int id, StudentUpdateDTO studentUpdateDTO);
    Task<string> DeleteStudentAsync(int id);
}