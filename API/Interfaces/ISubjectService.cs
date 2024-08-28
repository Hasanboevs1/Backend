using API.DTOs.SubjectDTOs;

namespace API.Interfaces;

public interface ISubjectService
{
    Task<IEnumerable<SubjectDTO>> GetAllSubjectsAsync();
    Task<SubjectDTO> GetSubjectByIdAsync(int id);
    Task<SubjectDTO> CreateSubjectAsync(SubjectCreateDTO subjectCreateDTO);
    Task<string> UpdateSubjectAsync(int id, SubjectUpdateDTO subjectUpdateDTO);
    Task<string> DeleteSubjectAsync(int id);
}