using API.Interfaces;
using API.Services;

namespace API.Exstensions;

public static class ServiceExtensions
{
    public static void AddServices(this IServiceCollection services)
    {   
        services.AddScoped<IStudentService, StudentService>();
        services.AddScoped<ISubjectService, SubjectService>();
        services.AddScoped<ITeacherService, TeacherService>();
        services.AddScoped<ITaskService, TaskService>();
    }
}