using API.DTOs.StudentDTOs;
using API.DTOs.SubjectDTOs;
using API.DTOs.TeacherDTOs;
using API.Entities;

namespace API.Interfaces;

public interface ITaskService
{
    ValueTask<List<StudentDTO>> ShowStudentsUnder20YearsOld();
    ValueTask<List<StudentDTO>> ShowStudentsBornBetweenAugust12AndSeptember18();
    ValueTask<List<TeacherDTO>> ShowTeachersOver55();
    ValueTask<List<string>> ShowBeelineUsers();
    ValueTask<List<StudentDTO>> GetStudentsByNamePhrase(string phrase);
    ValueTask<SubjectDTO> GetStudentHighestScoringSubject(int studentId);
    ValueTask<List<SubjectDTO>> GetSubjectsTaughtByTeacherWithHighScoringStudents(int teacherId);
    ValueTask<List<TeacherDTO>> GetTeachersWithHighScoringSubjects();
    ValueTask<SubjectDTO> GetSubjectWithHighestAverageGrade();
}