using API.DTOs.TeacherDTOs;

namespace API.Interfaces;

public interface ITeacherService
    {
        Task<IEnumerable<TeacherDTO>> GetAllTeachersAsync();
        Task<TeacherDTO> GetTeacherByIdAsync(int id);
        Task<TeacherDTO> CreateTeacherAsync(TeacherCreateDTO teacherCreateDTO);
        Task<string> UpdateTeacherAsync(int id, TeacherUpdateDTO teacherUpdateDTO);
        Task<string> DeleteTeacherAsync(int id);
    }