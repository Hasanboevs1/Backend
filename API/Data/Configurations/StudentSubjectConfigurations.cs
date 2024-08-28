using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations;

public class StudentSubjectConfigurations : IEntityTypeConfiguration<StudentSubject>
{
    public void Configure(EntityTypeBuilder<StudentSubject> builder)
    {
        builder.HasData(
            new StudentSubject { StudentId = 1, SubjectId = 1, Grade = 85.0 },
            new StudentSubject { StudentId = 1, SubjectId = 2, Grade = 98.0 },
            new StudentSubject { StudentId = 1, SubjectId = 3, Grade = 88.0 },
            new StudentSubject { StudentId = 2, SubjectId = 1, Grade = 78.0 },
            new StudentSubject { StudentId = 2, SubjectId = 3, Grade = 82.0 },
            new StudentSubject { StudentId = 2, SubjectId = 4, Grade = 99.0 },
            new StudentSubject { StudentId = 3, SubjectId = 2, Grade = 88.0 },
            new StudentSubject { StudentId = 3, SubjectId = 4, Grade = 98.0 },
            new StudentSubject { StudentId = 3, SubjectId = 5, Grade = 77.0 },
            new StudentSubject { StudentId = 4, SubjectId = 5, Grade = 75.0 },
            new StudentSubject { StudentId = 4, SubjectId = 6, Grade = 100.0 },
            new StudentSubject { StudentId = 4, SubjectId = 2, Grade = 80.0 },
            new StudentSubject { StudentId = 5, SubjectId = 7, Grade = 99.0 },
            new StudentSubject { StudentId = 5, SubjectId = 8, Grade = 80.0 },
            new StudentSubject { StudentId = 5, SubjectId = 3, Grade = 86.0 },
            new StudentSubject { StudentId = 6, SubjectId = 3, Grade = 82.0 },
            new StudentSubject { StudentId = 6, SubjectId = 2, Grade = 88.0 },
            new StudentSubject { StudentId = 6, SubjectId = 4, Grade = 99.0 },
            new StudentSubject { StudentId = 7, SubjectId = 4, Grade = 98.0 },
            new StudentSubject { StudentId = 7, SubjectId = 5, Grade = 75.0 },
            new StudentSubject { StudentId = 7, SubjectId = 6, Grade = 87.0 },
            new StudentSubject { StudentId = 8, SubjectId = 1, Grade = 85.0 },
            new StudentSubject { StudentId = 8, SubjectId = 2, Grade = 100.0 },
            new StudentSubject { StudentId = 8, SubjectId = 5, Grade = 77.0 },
            new StudentSubject { StudentId = 9, SubjectId = 1, Grade = 98.0 },
            new StudentSubject { StudentId = 9, SubjectId = 3, Grade = 82.0 },
            new StudentSubject { StudentId = 9, SubjectId = 4, Grade = 84.0 },
            new StudentSubject { StudentId = 10, SubjectId = 3, Grade = 82.0 },
            new StudentSubject { StudentId = 10, SubjectId = 2, Grade = 98.0 },
            new StudentSubject { StudentId = 10, SubjectId = 5, Grade = 79.0 },
            new StudentSubject { StudentId = 11, SubjectId = 6, Grade = 85.0 },
            new StudentSubject { StudentId = 11, SubjectId = 1, Grade = 99.0 },
            new StudentSubject { StudentId = 11, SubjectId = 3, Grade = 83.0 },
            new StudentSubject { StudentId = 12, SubjectId = 2, Grade = 99.0 },
            new StudentSubject { StudentId = 12, SubjectId = 5, Grade = 84.0 },
            new StudentSubject { StudentId = 12, SubjectId = 4, Grade = 77.0 },
            new StudentSubject { StudentId = 13, SubjectId = 1, Grade = 98.0 },
            new StudentSubject { StudentId = 13, SubjectId = 7, Grade = 93.0 },
            new StudentSubject { StudentId = 13, SubjectId = 8, Grade = 79.0 },
            new StudentSubject { StudentId = 14, SubjectId = 4, Grade = 85.0 },
            new StudentSubject { StudentId = 14, SubjectId = 3, Grade = 87.0 },
            new StudentSubject { StudentId = 14, SubjectId = 6, Grade = 98.0 },
            new StudentSubject { StudentId = 15, SubjectId = 2, Grade = 82.0 },
            new StudentSubject { StudentId = 15, SubjectId = 1, Grade = 87.5 },
            new StudentSubject { StudentId = 15, SubjectId = 5, Grade = 78.0 },
            new StudentSubject { StudentId = 16, SubjectId = 3, Grade = 80.0 },
            new StudentSubject { StudentId = 16, SubjectId = 4, Grade = 97.2 },
            new StudentSubject { StudentId = 16, SubjectId = 2, Grade = 84.0 },
            new StudentSubject { StudentId = 17, SubjectId = 6, Grade = 99.1 },
            new StudentSubject { StudentId = 17, SubjectId = 7, Grade = 89.0 },
            new StudentSubject { StudentId = 17, SubjectId = 3, Grade = 91.0 },
            new StudentSubject { StudentId = 18, SubjectId = 8, Grade = 76.0 },
            new StudentSubject { StudentId = 18, SubjectId = 4, Grade = 100.0 },
            new StudentSubject { StudentId = 18, SubjectId = 2, Grade = 87.0 },
            new StudentSubject { StudentId = 19, SubjectId = 5, Grade = 90.0 },
            new StudentSubject { StudentId = 19, SubjectId = 1, Grade = 79.0 },
            new StudentSubject { StudentId = 19, SubjectId = 6, Grade = 98.1 },
            new StudentSubject { StudentId = 20, SubjectId = 3, Grade = 81.0 },
            new StudentSubject { StudentId = 20, SubjectId = 7, Grade = 85.0 },
            new StudentSubject { StudentId = 20, SubjectId = 8, Grade = 99.0 },
            new StudentSubject { StudentId = 21, SubjectId = 6, Grade = 90.0 },
            new StudentSubject { StudentId = 21, SubjectId = 4, Grade = 99.0 },
            new StudentSubject { StudentId = 21, SubjectId = 2, Grade = 87.0 },
            new StudentSubject { StudentId = 22, SubjectId = 3, Grade = 91.0 },
            new StudentSubject { StudentId = 22, SubjectId = 8, Grade = 79.0 },
            new StudentSubject { StudentId = 22, SubjectId = 7, Grade = 98.0 },
            new StudentSubject { StudentId = 23, SubjectId = 5, Grade = 99.0 },
            new StudentSubject { StudentId = 23, SubjectId = 1, Grade = 89.0 },
            new StudentSubject { StudentId = 23, SubjectId = 4, Grade = 80.0 },
            new StudentSubject { StudentId = 24, SubjectId = 2, Grade = 97.9 },
            new StudentSubject { StudentId = 24, SubjectId = 3, Grade = 78.0 },
            new StudentSubject { StudentId = 24, SubjectId = 6, Grade = 85.0 },
            new StudentSubject { StudentId = 25, SubjectId = 8, Grade = 80.0 },
            new StudentSubject { StudentId = 25, SubjectId = 7, Grade = 99.0 },
            new StudentSubject { StudentId = 25, SubjectId = 5, Grade = 84.0 },
            new StudentSubject { StudentId = 26, SubjectId = 1, Grade = 90.0 },
            new StudentSubject { StudentId = 26, SubjectId = 3, Grade = 98.0 },
            new StudentSubject { StudentId = 26, SubjectId = 6, Grade = 85.0 },
            new StudentSubject { StudentId = 27, SubjectId = 4, Grade = 87.0 },
            new StudentSubject { StudentId = 27, SubjectId = 2, Grade = 98.0 },
            new StudentSubject { StudentId = 27, SubjectId = 1, Grade = 79.0 },
            new StudentSubject { StudentId = 28, SubjectId = 7, Grade = 92.0 },
            new StudentSubject { StudentId = 28, SubjectId = 5, Grade = 99.0 },
            new StudentSubject { StudentId = 28, SubjectId = 8, Grade = 81.0 },
            new StudentSubject { StudentId = 29, SubjectId = 3, Grade = 83.0 },
            new StudentSubject { StudentId = 29, SubjectId = 4, Grade = 85.0 },
            new StudentSubject { StudentId = 29, SubjectId = 2, Grade = 100.0 },
            new StudentSubject { StudentId = 30, SubjectId = 1, Grade = 88.0 },
            new StudentSubject { StudentId = 30, SubjectId = 5, Grade = 79.0 },
            new StudentSubject { StudentId = 30, SubjectId = 6, Grade = 99.6 }
            );
    }
}
