namespace API.DTOs.TeacherDTOs;
public class TeacherUpdateDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public ICollection<int> SubjectIds { get; set; } // Only include subject IDs when updating
}
