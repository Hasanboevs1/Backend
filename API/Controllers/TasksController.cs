using API.DTOs.StudentDTOs;
using API.DTOs.SubjectDTOs;
using API.DTOs.TeacherDTOs;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService) => _taskService = taskService;

        [HttpGet]
        [Route("under20yearsold_students")]
        public async ValueTask<List<StudentDTO>> GetStudents() => await _taskService.ShowStudentsUnder20YearsOld();

        [HttpGet]
        [Route("students_born_between_august_12_and_september_18")]
        public async ValueTask<List<StudentDTO>> GetStudentsBornBetweenAugust12AndSeptember18() => await _taskService.ShowStudentsBornBetweenAugust12AndSeptember18();

        [HttpGet]
        [Route("over55_teachers")]
        public async ValueTask<List<TeacherDTO>> GetTeachers() => await _taskService.ShowTeachersOver55();

        [HttpGet]
        [Route("beeline_users")]
        public async ValueTask<List<string>> GetBeelineUsers() => await _taskService.ShowBeelineUsers();
        [HttpGet]
        [Route("students_by_name_phrase/{phrase}")]
        public async ValueTask<List<StudentDTO>> GetStudentsByNamePhrase(string phrase) => await _taskService.GetStudentsByNamePhrase(phrase);

        [HttpGet]
        [Route("student_highest_scoring_subject/{studentId}")]
        public async ValueTask<IActionResult> GetStudentHighestScoringSubject(int studentId)
        {
            var subject = await _taskService.GetStudentHighestScoringSubject(studentId);

            if(subject is null)
            {
                return NotFound("No_subject_found");
            }

            return Ok(subject);
        }

        [HttpGet]
        [Route("subjects_taught_by_teacher_with_high_scoring_students/{teacherId}")]
        public async ValueTask<List<SubjectDTO>> GetSubjectsTaughtByTeacherWithHighScoringStudents(int teacherId) => await _taskService.GetSubjectsTaughtByTeacherWithHighScoringStudents(teacherId);

        [HttpGet]
        [Route("teachers_with_high_scoring_subjects")]
        public async ValueTask<List<TeacherDTO>> GetTeachersWithHighScoringSubjects() => await _taskService.GetTeachersWithHighScoringSubjects();

        [HttpGet]
        [Route("subject_with_highest_average_grade")]
        public async ValueTask<IActionResult> GetSubjectWithHighestAverageGrade()
        {
            var subject = await _taskService.GetSubjectWithHighestAverageGrade();
            if (subject is null)
            {
                return NotFound("No_subject_found");
            }
            return Ok(subject);
        }
    }
}