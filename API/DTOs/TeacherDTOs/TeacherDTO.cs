namespace API.DTOs.TeacherDTOs;
public class TeacherDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public ICollection<TeacherSubjectDTO> Subjects { get; set; }
}