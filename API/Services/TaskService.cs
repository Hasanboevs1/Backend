using API.Data;
using API.DTOs.StudentDTOs;
using API.DTOs.SubjectDTOs;
using API.DTOs.TeacherDTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Services;

public class TaskService : ITaskService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    public TaskService(AppDbContext context, IMapper mapper) => (_context, _mapper) = (context, mapper);

    public async ValueTask<SubjectDTO> GetStudentHighestScoringSubject(int studentId)
    {
         var studentSubject = await _context.StudentSubjects
        .Where(ss => ss.StudentId == studentId)
        .OrderByDescending(ss => ss.Grade)
        .Select(ss => ss.Subject)
        .FirstOrDefaultAsync();

        if (studentSubject == null)
        {
            return null;  // Handle case where no subjects are found for the student
        }

        return _mapper.Map<SubjectDTO>(studentSubject);
    }

    public async ValueTask<List<StudentDTO>> GetStudentsByNamePhrase(string phrase)
    {
        var lowerCasePhrase = phrase.ToLower();
        var students = await _context.Students
                .Where(x => x.FirstName.ToLower().Contains(lowerCasePhrase) ||
                            x.LastName.ToLower().Contains(lowerCasePhrase))
                .Include(x => x.Subjects)
                .ThenInclude(x => x.Subject)
                .ToListAsync();

        return _mapper.Map<List<StudentDTO>>(students);
    }

    public async ValueTask<List<SubjectDTO>> GetSubjectsTaughtByTeacherWithHighScoringStudents(int teacherId)
    {
        var subjects = await _context.TeacherSubjects
                .Where(ts => ts.TeacherId == teacherId)
                .Select(ts => ts.Subject)
                .ToListAsync();
        
        var result = new List<Subject>();

        foreach (var subject in subjects)
            {
                var highScoringStudentsCount = await _context.StudentSubjects
                    .Where(ss => ss.SubjectId == subject.Id && ss.Grade > 80)
                    .CountAsync();

                if (highScoringStudentsCount >= 10)
                {
                    result.Add(subject);
                }
            }

        return _mapper.Map<List<SubjectDTO>>(result);
    }

    public async ValueTask<SubjectDTO> GetSubjectWithHighestAverageGrade()
    {
        var subjectWithHighestAvgGrade = await _context.StudentSubjects
                .GroupBy(ss => ss.SubjectId)
                .Select(g => new
                {
                    SubjectId = g.Key,
                    AverageGrade = g.Average(ss => ss.Grade)
                })
                .OrderByDescending(g => g.AverageGrade)
                .FirstOrDefaultAsync();

            if (subjectWithHighestAvgGrade == null)
            {
                return null;  // Handle case where no subjects are found
            }

            var subject = await _context.Subjects
                .Where(s => s.Id == subjectWithHighestAvgGrade.SubjectId)
                .FirstOrDefaultAsync();

            return _mapper.Map<SubjectDTO>(subject);
    }

    public async ValueTask<List<TeacherDTO>> GetTeachersWithHighScoringSubjects()
    {
        var highScoringSubjects = await _context.StudentSubjects
                .GroupBy(ss => ss.SubjectId)
                .Where(g => g.Max(ss => ss.Grade) > 97)
                .Select(g => g.Key)
                .ToListAsync();

        var teachers = await _context.TeacherSubjects
                .Where(ts => highScoringSubjects.Contains(ts.SubjectId))
                .Select(ts => ts.Teacher)
                .Distinct()
                .Include(t => t.Subjects)
                .ThenInclude(t => t.Subject)
                .ToListAsync();
                
        return _mapper.Map<List<TeacherDTO>>(teachers);
    }

    public async ValueTask<List<string>> ShowBeelineUsers()
    {
        var beelinePrefixes = new[] { "+99890", "+99891" };
        var list = new List<string>();
        var students = await _context.Students
            .Where(x => beelinePrefixes.Any(prefix => x.PhoneNumber.StartsWith(prefix)))
            .ToListAsync();

        foreach (var student in students)
        {
            list.Add(student.FirstName);
        }

        var teachers = await _context.Teachers
            .Where(x => beelinePrefixes.Any(prefix => x.PhoneNumber.StartsWith(prefix)))
            .ToListAsync();

        foreach (var teacher in teachers)
        {
            list.Add(teacher.FirstName);
        }

        return list;
    }

    public async ValueTask<List<StudentDTO>> ShowStudentsBornBetweenAugust12AndSeptember18()
    {
        var startMonth = 8;  // August
        var startDay = 12;
        var endMonth = 9;    // September
        var endDay = 18;

        var startDate = new DateTime(DateTime.Now.Year, startMonth, startDay);
        var endDate = new DateTime(DateTime.Now.Year, endMonth, endDay);

        var startDayOfYear = startDate.DayOfYear;
        var endDayOfYear = endDate.DayOfYear;

        var students = await _context.Students
        .Where(x => startDayOfYear <= endDayOfYear
           ? x.BirthDate.DayOfYear >= startDayOfYear && x.BirthDate.DayOfYear <= endDayOfYear
           : x.BirthDate.DayOfYear >= startDayOfYear || x.BirthDate.DayOfYear <= endDayOfYear)
        .Include(x => x.Subjects)  
            .ThenInclude(x => x.Subject) 
                .ToListAsync();

        return _mapper.Map<List<StudentDTO>>(students);
    }

    public async ValueTask<List<StudentDTO>> ShowStudentsUnder20YearsOld()
    {
        var twentyYearsAgo = DateTime.Today.AddYears(-20);

        // Students born after this date are under 20 years old
        var students = await _context.Students
            .Where(x => x.BirthDate > twentyYearsAgo)
            .Include(x => x.Subjects)
                .ThenInclude(x => x.Subject)
            .ToListAsync();

        return _mapper.Map<List<StudentDTO>>(students);
    }


    public async ValueTask<List<TeacherDTO>> ShowTeachersOver55()
    {
        var teachers = await _context.Teachers
            .Where(x => x.BirthDate < DateTime.Now.AddYears(-55))
            .Include(x => x.Subjects)
                .ThenInclude(x => x.Subject)
                    .ToListAsync();
        return _mapper.Map<List<TeacherDTO>>(teachers);
    }
}