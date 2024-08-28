using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations
{
    public class SubjectConfigurations : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            // Seed Subjects
            builder.HasData(
                new Subject { Id = 1, Name = "Mathematics" },
                new Subject { Id = 2, Name = "Physics" },
                new Subject { Id = 3, Name = "Chemistry" },
                new Subject { Id = 4, Name = "Biology" },
                new Subject { Id = 5, Name = "History" },
                new Subject { Id = 6, Name = "Geography" },
                new Subject { Id = 7, Name = "Economics" },
                new Subject { Id = 8, Name = "Literature" },
                new Subject { Id = 9, Name = "Art" },
                new Subject { Id = 10, Name = "Computer Science" }
            );
        }
    }
}
