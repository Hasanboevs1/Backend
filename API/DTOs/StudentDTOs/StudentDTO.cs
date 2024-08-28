namespace API.DTOs.StudentDTOs;

public class StudentDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public string StudentRegNumber { get; set; }
    public ICollection<StudentSubjectDTO> Subjects { get; set; }
}
