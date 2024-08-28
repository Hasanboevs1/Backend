using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StudentRegNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubjects",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    Grade = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjects", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSubjects",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSubjects", x => new { x.TeacherId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "StudentRegNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice.smith@example.com", "Alice", "Smith", "555-1234", "STU10001" },
                    { 2, new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.johnson@example.com", "Bob", "Johnson", "555-5678", "STU10002" },
                    { 3, new DateTime(1999, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "charlie.brown@example.com", "Charlie", "Brown", "555-8765", "STU10003" },
                    { 4, new DateTime(2002, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "diana.prince@example.com", "Diana", "Prince", "555-9999", "STU10004" },
                    { 5, new DateTime(2003, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "eva.green@example.com", "Eva", "Green", "555-1122", "STU10005" },
                    { 6, new DateTime(2004, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "frank.moore@example.com", "Frank", "Moore", "555-2233", "STU10006" },
                    { 7, new DateTime(2005, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "grace.lee@example.com", "Grace", "Lee", "555-3344", "STU10007" },
                    { 8, new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "hannah.wilson@example.com", "Hannah", "Wilson", "555-4455", "STU10008" },
                    { 9, new DateTime(2007, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ian.taylor@example.com", "Ian", "Taylor", "555-5566", "STU10009" },
                    { 10, new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jasmine.anderson@example.com", "Jasmine", "Anderson", "555-6677", "STU10010" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mathematics" },
                    { 2, "Physics" },
                    { 3, "Chemistry" },
                    { 4, "Biology" },
                    { 5, "History" },
                    { 6, "Geography" },
                    { 7, "Economics" },
                    { 8, "Literature" },
                    { 9, "Art" },
                    { 10, "Computer Science" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1975, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", "555-7777" },
                    { 2, new DateTime(1980, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Smith", "555-8888" },
                    { 3, new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "robert.johnson@example.com", "Robert", "Johnson", "555-9999" },
                    { 4, new DateTime(1990, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.davis@example.com", "Emily", "Davis", "555-1010" },
                    { 5, new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.wilson@example.com", "Michael", "Wilson", "555-2020" },
                    { 6, new DateTime(2000, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah.taylor@example.com", "Sarah", "Taylor", "555-3030" },
                    { 7, new DateTime(1978, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.brown@example.com", "David", "Brown", "555-4040" },
                    { 8, new DateTime(1982, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "laura.miller@example.com", "Laura", "Miller", "555-5050" },
                    { 9, new DateTime(1987, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.wilson@example.com", "James", "Wilson", "555-6060" },
                    { 10, new DateTime(1992, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "olivia.moore@example.com", "Olivia", "Moore", "555-7070" }
                });

            migrationBuilder.InsertData(
                table: "StudentSubjects",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 1, 1, 85.0 },
                    { 1, 2, 90.0 },
                    { 2, 1, 78.0 },
                    { 2, 3, 82.0 },
                    { 3, 2, 88.0 },
                    { 3, 4, 91.0 },
                    { 4, 5, 75.0 },
                    { 4, 6, 85.0 },
                    { 5, 7, 92.0 },
                    { 5, 8, 80.0 }
                });

            migrationBuilder.InsertData(
                table: "TeacherSubjects",
                columns: new[] { "SubjectId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_SubjectId",
                table: "StudentSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjects_SubjectId",
                table: "TeacherSubjects",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubjects");

            migrationBuilder.DropTable(
                name: "TeacherSubjects");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
