using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations
{
    public class TeacherConfigurations : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            // Seed Teachers
            builder.HasData(
                new Teacher
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    PhoneNumber = "+998901234567",
                    Email = "john.doe@example.com",
                    BirthDate = new DateTime(1975, 8, 20)
                },
                new Teacher
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    PhoneNumber = "+998912345678",
                    Email = "jane.smith@example.com",
                    BirthDate = new DateTime(1940, 9, 15)
                },
                new Teacher
                {
                    Id = 3,
                    FirstName = "Robert",
                    LastName = "Johnson",
                    PhoneNumber = "+998933456789",
                    Email = "robert.johnson@example.com",
                    BirthDate = new DateTime(1955, 10, 10)
                },
                new Teacher
                {
                    Id = 4,
                    FirstName = "Emily",
                    LastName = "Davis",
                    PhoneNumber = "+998944567890",
                    Email = "emily.davis@example.com",
                    BirthDate = new DateTime(1990, 11, 5)
                },
                new Teacher
                {
                    Id = 5,
                    FirstName = "Michael",
                    LastName = "Wilson",
                    PhoneNumber = "+998955678901",
                    Email = "michael.wilson@example.com",
                    BirthDate = new DateTime(1995, 12, 1)
                },
                new Teacher
                {
                    Id = 6,
                    FirstName = "Sarah",
                    LastName = "Taylor",
                    PhoneNumber = "+998966789012",
                    Email = "sarah.taylor@example.com",
                    BirthDate = new DateTime(2000, 1, 20)
                },
                new Teacher
                {
                    Id = 7,
                    FirstName = "David",
                    LastName = "Brown",
                    PhoneNumber = "+998977890123",
                    Email = "david.brown@example.com",
                    BirthDate = new DateTime(1978, 2, 25)
                },
                new Teacher
                {
                    Id = 8,
                    FirstName = "Laura",
                    LastName = "Miller",
                    PhoneNumber = "+998988901234",
                    Email = "laura.miller@example.com",
                    BirthDate = new DateTime(1982, 3, 15)
                },
                new Teacher
                {
                    Id = 9,
                    FirstName = "James",
                    LastName = "Wilson",
                    PhoneNumber = "+998999012345",
                    Email = "james.wilson@example.com",
                    BirthDate = new DateTime(1987, 4, 10)
                },
                new Teacher
                {
                    Id = 10,
                    FirstName = "Olivia",
                    LastName = "Moore",
                    PhoneNumber = "+998901234567",
                    Email = "olivia.moore@example.com",
                    BirthDate = new DateTime(1992, 5, 5)
                }
            );
        }
    }
}
