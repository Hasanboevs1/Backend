using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataCompletely : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "Grade",
                value: 98.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 4 },
                column: "Grade",
                value: 98.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "Grade",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 7 },
                column: "Grade",
                value: 99.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 4 },
                column: "Grade",
                value: 98.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 2 },
                column: "Grade",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 1 },
                column: "Grade",
                value: 98.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 2 },
                column: "Grade",
                value: 98.0);

            migrationBuilder.InsertData(
                table: "StudentSubjects",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 1, 3, 88.0 },
                    { 2, 4, 99.0 },
                    { 3, 5, 77.0 },
                    { 4, 2, 80.0 },
                    { 5, 3, 86.0 },
                    { 6, 4, 99.0 },
                    { 7, 6, 87.0 },
                    { 8, 5, 77.0 },
                    { 9, 4, 84.0 },
                    { 10, 5, 79.0 }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "+998901234567");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: "+998901234568");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNumber",
                value: "+998901234569");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhoneNumber",
                value: "+998901234570");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhoneNumber",
                value: "+998901234571");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhoneNumber",
                value: "+998901234572");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhoneNumber",
                value: "+998901234573");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhoneNumber",
                value: "+998901234574");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "PhoneNumber",
                value: "+998901234575");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "PhoneNumber",
                value: "+998901234576");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "StudentRegNumber" },
                values: new object[,]
                {
                    { 11, new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "kevin.white@example.com", "Kevin", "White", "+998901234577", "STU10011" },
                    { 12, new DateTime(2000, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "laura.harris@example.com", "Laura", "Harris", "+998901234578", "STU10012" },
                    { 13, new DateTime(1999, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.clark@example.com", "Michael", "Clark", "+998901234579", "STU10013" },
                    { 14, new DateTime(2002, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "natalie.martinez@example.com", "Natalie", "Martinez", "+998901234580", "STU10014" },
                    { 15, new DateTime(2003, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "oscar.garcia@example.com", "Oscar", "Garcia", "+998901234581", "STU10015" },
                    { 16, new DateTime(2004, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "paul.rodriguez@example.com", "Paul", "Rodriguez", "+998901234582", "STU10016" },
                    { 17, new DateTime(2005, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "quinn.lewis@example.com", "Quinn", "Lewis", "+998901234583", "STU10017" },
                    { 18, new DateTime(2006, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "rachel.walker@example.com", "Rachel", "Walker", "+998901234584", "STU10018" },
                    { 19, new DateTime(2007, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "samuel.hall@example.com", "Samuel", "Hall", "+998901234585", "STU10019" },
                    { 20, new DateTime(2008, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "tina.allen@example.com", "Tina", "Allen", "+998901234586", "STU10020" },
                    { 21, new DateTime(2001, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "uma.young@example.com", "Uma", "Young", "+998901234587", "STU10021" },
                    { 22, new DateTime(2000, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "victor.king@example.com", "Victor", "King", "+998901234588", "STU10022" },
                    { 23, new DateTime(1999, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "wendy.wright@example.com", "Wendy", "Wright", "+998901234589", "STU10023" },
                    { 24, new DateTime(2002, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "xavier.lopez@example.com", "Xavier", "Lopez", "+998901234590", "STU10024" },
                    { 25, new DateTime(2003, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "yasmin.hill@example.com", "Yasmin", "Hill", "+998901234591", "STU10025" },
                    { 26, new DateTime(2004, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "zachary.scott@example.com", "Zachary", "Scott", "+998901234592", "STU10026" },
                    { 27, new DateTime(2005, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "amelia.adams@example.com", "Amelia", "Adams", "+998901234593", "STU10027" },
                    { 28, new DateTime(2006, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "brian.nelson@example.com", "Brian", "Nelson", "+998901234594", "STU10028" },
                    { 29, new DateTime(2007, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "chloe.carter@example.com", "Chloe", "Carter", "+998901234595", "STU10029" },
                    { 30, new DateTime(2008, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel.mitchell@example.com", "Daniel", "Mitchell", "+998901234596", "STU10030" }
                });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "+998901234567");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: "+998912345678");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNumber",
                value: "+998933456789");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhoneNumber",
                value: "+998944567890");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhoneNumber",
                value: "+998955678901");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhoneNumber",
                value: "+998966789012");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhoneNumber",
                value: "+998977890123");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhoneNumber",
                value: "+998988901234");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9,
                column: "PhoneNumber",
                value: "+998999012345");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10,
                column: "PhoneNumber",
                value: "+998901234567");

            migrationBuilder.InsertData(
                table: "StudentSubjects",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 11, 1, 99.0 },
                    { 11, 3, 83.0 },
                    { 11, 6, 85.0 },
                    { 12, 2, 99.0 },
                    { 12, 4, 77.0 },
                    { 12, 5, 84.0 },
                    { 13, 1, 98.0 },
                    { 13, 7, 93.0 },
                    { 13, 8, 79.0 },
                    { 14, 3, 87.0 },
                    { 14, 4, 85.0 },
                    { 14, 6, 98.0 },
                    { 15, 1, 87.5 },
                    { 15, 2, 82.0 },
                    { 15, 5, 78.0 },
                    { 16, 2, 84.0 },
                    { 16, 3, 80.0 },
                    { 16, 4, 97.200000000000003 },
                    { 17, 3, 91.0 },
                    { 17, 6, 99.099999999999994 },
                    { 17, 7, 89.0 },
                    { 18, 2, 87.0 },
                    { 18, 4, 100.0 },
                    { 18, 8, 76.0 },
                    { 19, 1, 79.0 },
                    { 19, 5, 90.0 },
                    { 19, 6, 98.099999999999994 },
                    { 20, 3, 81.0 },
                    { 20, 7, 85.0 },
                    { 20, 8, 99.0 },
                    { 21, 2, 87.0 },
                    { 21, 4, 99.0 },
                    { 21, 6, 90.0 },
                    { 22, 3, 91.0 },
                    { 22, 7, 98.0 },
                    { 22, 8, 79.0 },
                    { 23, 1, 89.0 },
                    { 23, 4, 80.0 },
                    { 23, 5, 99.0 },
                    { 24, 2, 97.900000000000006 },
                    { 24, 3, 78.0 },
                    { 24, 6, 85.0 },
                    { 25, 5, 84.0 },
                    { 25, 7, 99.0 },
                    { 25, 8, 80.0 },
                    { 26, 1, 90.0 },
                    { 26, 3, 98.0 },
                    { 26, 6, 85.0 },
                    { 27, 1, 79.0 },
                    { 27, 2, 98.0 },
                    { 27, 4, 87.0 },
                    { 28, 5, 99.0 },
                    { 28, 7, 92.0 },
                    { 28, 8, 81.0 },
                    { 29, 2, 100.0 },
                    { 29, 3, 83.0 },
                    { 29, 4, 85.0 },
                    { 30, 1, 88.0 },
                    { 30, 5, 79.0 },
                    { 30, 6, 99.599999999999994 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 18, 8 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 22, 7 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 22, 8 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 25, 8 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 26, 3 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 28, 7 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 28, 8 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 30, 6 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "Grade",
                value: 90.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 4 },
                column: "Grade",
                value: 91.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "Grade",
                value: 85.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 7 },
                column: "Grade",
                value: 92.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 4 },
                column: "Grade",
                value: 91.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 2 },
                column: "Grade",
                value: 90.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 1 },
                column: "Grade",
                value: 78.0);

            migrationBuilder.UpdateData(
                table: "StudentSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 2 },
                column: "Grade",
                value: 88.0);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "555-1234");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: "555-5678");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNumber",
                value: "555-8765");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhoneNumber",
                value: "555-9999");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhoneNumber",
                value: "555-1122");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhoneNumber",
                value: "555-2233");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhoneNumber",
                value: "555-3344");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhoneNumber",
                value: "555-4455");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "PhoneNumber",
                value: "555-5566");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "PhoneNumber",
                value: "555-6677");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "555-7777");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: "555-8888");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNumber",
                value: "555-9999");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhoneNumber",
                value: "555-1010");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhoneNumber",
                value: "555-2020");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhoneNumber",
                value: "555-3030");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhoneNumber",
                value: "555-4040");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhoneNumber",
                value: "555-5050");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9,
                column: "PhoneNumber",
                value: "555-6060");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10,
                column: "PhoneNumber",
                value: "555-7070");
        }
    }
}
