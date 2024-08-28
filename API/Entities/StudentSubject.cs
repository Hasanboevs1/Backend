namespace API.Entities;
public class StudentSubject
{
    public int StudentId { get; set; }
    public Student Student { get; set; }

    public int SubjectId { get; set; }
    public Subject Subject { get; set; }

    public double Grade { get; set; }
}
