using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFD2.Migrations
{
    /// <inheritdoc />
    public partial class v12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeProject",
                columns: table => new
                {
                    Employeesid = table.Column<int>(type: "int", nullable: false),
                    Projectsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProject", x => new { x.Employeesid, x.Projectsid });
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Employees_Employeesid",
                        column: x => x.Employeesid,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Projects_Projectsid",
                        column: x => x.Projectsid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_Projectsid",
                table: "EmployeeProject",
                column: "Projectsid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProject");
        }
    }
}
