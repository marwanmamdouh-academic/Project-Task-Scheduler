using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarwanMamdohW2_0523016.Migrations
{
    /// <inheritdoc />
    public partial class Frist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    Projectid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.Projectid);
                });

            migrationBuilder.CreateTable(
                name: "teamMembers",
                columns: table => new
                {
                    TeamMemberid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teamMembers", x => x.TeamMemberid);
                });

            migrationBuilder.CreateTable(
                name: "tasks",
                columns: table => new
                {
                    taskid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prirority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pid = table.Column<int>(type: "int", nullable: false),
                    memid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks", x => x.taskid);
                    table.ForeignKey(
                        name: "FK_tasks_projects_pid",
                        column: x => x.pid,
                        principalTable: "projects",
                        principalColumn: "Projectid");
                    table.ForeignKey(
                        name: "FK_tasks_teamMembers_memid",
                        column: x => x.memid,
                        principalTable: "teamMembers",
                        principalColumn: "TeamMemberid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tasks_memid",
                table: "tasks",
                column: "memid");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_pid",
                table: "tasks",
                column: "pid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tasks");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "teamMembers");
        }
    }
}
