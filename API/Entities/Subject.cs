namespace API.Entities;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<StudentSubject> StudentSubjects { get; set; }
    public ICollection<TeacherSubject> TeacherSubjects { get; set; }
}
