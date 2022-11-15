using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class EntityFrameworkNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Clubid = table.Column<string>(name: "Club_id", type: "nvarchar(450)", nullable: false),
                    clubname = table.Column<string>(name: "club_name", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Clubid);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Courseid = table.Column<int>(name: "Course_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouseName = table.Column<string>(name: "Couse_Name", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Courseid);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentId = table.Column<int>(name: "student_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentName = table.Column<string>(name: "student_Name", type: "nvarchar(max)", nullable: false),
                    studentdob = table.Column<DateTime>(name: "student_dob", type: "datetime2", nullable: false),
                    Clubid = table.Column<string>(name: "Club_id", type: "nvarchar(450)", nullable: true),
                    Courseid = table.Column<int>(name: "Course_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentId);
                    table.ForeignKey(
                        name: "FK_Students_Clubs_Club_id",
                        column: x => x.Clubid,
                        principalTable: "Clubs",
                        principalColumn: "Club_id");
                    table.ForeignKey(
                        name: "FK_Students_Courses_Course_id",
                        column: x => x.Courseid,
                        principalTable: "Courses",
                        principalColumn: "Course_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Club_id",
                table: "Students",
                column: "Club_id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Course_id",
                table: "Students",
                column: "Course_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
