using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student { Id = 1, FirstName = "Alice", LastName = "Smith", PhoneNumber = "+998901234567", Email = "alice.smith@example.com", BirthDate = new DateTime(2001, 5, 15), StudentRegNumber = "STU10001" },
                new Student { Id = 2, FirstName = "Bob", LastName = "Johnson", PhoneNumber = "+998901234568", Email = "bob.johnson@example.com", BirthDate = new DateTime(2000, 11, 20), StudentRegNumber = "STU10002" },
                new Student { Id = 3, FirstName = "Charlie", LastName = "Brown", PhoneNumber = "+998901234569", Email = "charlie.brown@example.com", BirthDate = new DateTime(1999, 7, 23), StudentRegNumber = "STU10003" },
                new Student { Id = 4, FirstName = "Diana", LastName = "Prince", PhoneNumber = "+998901234570", Email = "diana.prince@example.com", BirthDate = new DateTime(2002, 10, 10), StudentRegNumber = "STU10004" },
                new Student { Id = 5, FirstName = "Eva", LastName = "Green", PhoneNumber = "+998901234571", Email = "eva.green@example.com", BirthDate = new DateTime(2003, 1, 25), StudentRegNumber = "STU10005" },
                new Student { Id = 6, FirstName = "Frank", LastName = "Moore", PhoneNumber = "+998901234572", Email = "frank.moore@example.com", BirthDate = new DateTime(2004, 2, 14), StudentRegNumber = "STU10006" },
                new Student { Id = 7, FirstName = "Grace", LastName = "Lee", PhoneNumber = "+998901234573", Email = "grace.lee@example.com", BirthDate = new DateTime(2005, 3, 19), StudentRegNumber = "STU10007" },
                new Student { Id = 8, FirstName = "Hannah", LastName = "Wilson", PhoneNumber = "+998901234574", Email = "hannah.wilson@example.com", BirthDate = new DateTime(2006, 4, 12), StudentRegNumber = "STU10008" },
                new Student { Id = 9, FirstName = "Ian", LastName = "Taylor", PhoneNumber = "+998901234575", Email = "ian.taylor@example.com", BirthDate = new DateTime(2007, 5, 9), StudentRegNumber = "STU10009" },
                new Student { Id = 10, FirstName = "Jasmine", LastName = "Anderson", PhoneNumber = "+998901234576", Email = "jasmine.anderson@example.com", BirthDate = new DateTime(2008, 6, 15), StudentRegNumber = "STU10010" },
                new Student { Id = 11, FirstName = "Kevin", LastName = "White", PhoneNumber = "+998901234577", Email = "kevin.white@example.com", BirthDate = new DateTime(2001, 7, 20), StudentRegNumber = "STU10011" },
                new Student { Id = 12, FirstName = "Laura", LastName = "Harris", PhoneNumber = "+998901234578", Email = "laura.harris@example.com", BirthDate = new DateTime(2000, 8, 15), StudentRegNumber = "STU10012" },
                new Student { Id = 13, FirstName = "Michael", LastName = "Clark", PhoneNumber = "+998901234579", Email = "michael.clark@example.com", BirthDate = new DateTime(1999, 12, 12), StudentRegNumber = "STU10013" },
                new Student { Id = 14, FirstName = "Natalie", LastName = "Martinez", PhoneNumber = "+998901234580", Email = "natalie.martinez@example.com", BirthDate = new DateTime(2002, 2, 28), StudentRegNumber = "STU10014" },
                new Student { Id = 15, FirstName = "Oscar", LastName = "Garcia", PhoneNumber = "+998901234581", Email = "oscar.garcia@example.com", BirthDate = new DateTime(2003, 3, 3), StudentRegNumber = "STU10015" },
                new Student { Id = 16, FirstName = "Paul", LastName = "Rodriguez", PhoneNumber = "+998901234582", Email = "paul.rodriguez@example.com", BirthDate = new DateTime(2004, 4, 22), StudentRegNumber = "STU10016" },
                new Student { Id = 17, FirstName = "Quinn", LastName = "Lewis", PhoneNumber = "+998901234583", Email = "quinn.lewis@example.com", BirthDate = new DateTime(2005, 5, 25), StudentRegNumber = "STU10017" },
                new Student { Id = 18, FirstName = "Rachel", LastName = "Walker", PhoneNumber = "+998901234584", Email = "rachel.walker@example.com", BirthDate = new DateTime(2006, 6, 30), StudentRegNumber = "STU10018" },
                new Student { Id = 19, FirstName = "Samuel", LastName = "Hall", PhoneNumber = "+998901234585", Email = "samuel.hall@example.com", BirthDate = new DateTime(2007, 7, 27), StudentRegNumber = "STU10019" },
                new Student { Id = 20, FirstName = "Tina", LastName = "Allen", PhoneNumber = "+998901234586", Email = "tina.allen@example.com", BirthDate = new DateTime(2008, 8, 15), StudentRegNumber = "STU10020" },
                new Student { Id = 21, FirstName = "Uma", LastName = "Young", PhoneNumber = "+998901234587", Email = "uma.young@example.com", BirthDate = new DateTime(2001, 9, 14), StudentRegNumber = "STU10021" },
                new Student { Id = 22, FirstName = "Victor", LastName = "King", PhoneNumber = "+998901234588", Email = "victor.king@example.com", BirthDate = new DateTime(2000, 10, 13), StudentRegNumber = "STU10022" },
                new Student { Id = 23, FirstName = "Wendy", LastName = "Wright", PhoneNumber = "+998901234589", Email = "wendy.wright@example.com", BirthDate = new DateTime(1999, 11, 22), StudentRegNumber = "STU10023" },
                new Student { Id = 24, FirstName = "Xavier", LastName = "Lopez", PhoneNumber = "+998901234590", Email = "xavier.lopez@example.com", BirthDate = new DateTime(2002, 12, 30), StudentRegNumber = "STU10024" },
                new Student { Id = 25, FirstName = "Yasmin", LastName = "Hill", PhoneNumber = "+998901234591", Email = "yasmin.hill@example.com", BirthDate = new DateTime(2003, 1, 29), StudentRegNumber = "STU10025" },
                new Student { Id = 26, FirstName = "Zachary", LastName = "Scott", PhoneNumber = "+998901234592", Email = "zachary.scott@example.com", BirthDate = new DateTime(2004, 2, 27), StudentRegNumber = "STU10026" },
                new Student { Id = 27, FirstName = "Amelia", LastName = "Adams", PhoneNumber = "+998901234593", Email = "amelia.adams@example.com", BirthDate = new DateTime(2005, 3, 17), StudentRegNumber = "STU10027" },
                new Student { Id = 28, FirstName = "Brian", LastName = "Nelson", PhoneNumber = "+998901234594", Email = "brian.nelson@example.com", BirthDate = new DateTime(2006, 4, 5), StudentRegNumber = "STU10028" },
                new Student { Id = 29, FirstName = "Chloe", LastName = "Carter", PhoneNumber = "+998901234595", Email = "chloe.carter@example.com", BirthDate = new DateTime(2007, 5, 24), StudentRegNumber = "STU10029" },
                new Student { Id = 30, FirstName = "Daniel", LastName = "Mitchell", PhoneNumber = "+998901234596", Email = "daniel.mitchell@example.com", BirthDate = new DateTime(2008, 6, 7), StudentRegNumber = "STU10030" }
            );
        }
    }
}
