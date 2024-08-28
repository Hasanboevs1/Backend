using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations;
public class TeacherSubjectConfigurations : IEntityTypeConfiguration<TeacherSubject>
    {
        public void Configure(EntityTypeBuilder<TeacherSubject> builder)
        {
            
            builder.HasData(
                new TeacherSubject { TeacherId = 1, SubjectId = 1 },
                new TeacherSubject { TeacherId = 2, SubjectId = 2 },
                new TeacherSubject { TeacherId = 3, SubjectId = 3 },
                new TeacherSubject { TeacherId = 4, SubjectId = 4 },
                new TeacherSubject { TeacherId = 5, SubjectId = 5 },
                new TeacherSubject { TeacherId = 6, SubjectId = 6 },
                new TeacherSubject { TeacherId = 7, SubjectId = 7 },
                new TeacherSubject { TeacherId = 8, SubjectId = 8 },
                new TeacherSubject { TeacherId = 9, SubjectId = 9 },
                new TeacherSubject { TeacherId = 10, SubjectId = 10 }
            );
        }
    }