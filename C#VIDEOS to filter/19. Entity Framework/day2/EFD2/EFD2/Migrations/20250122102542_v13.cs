using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFD2.Migrations
{
    /// <inheritdoc />
    public partial class v13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProject");

            migrationBuilder.CreateTable(
                name: "EmpProjs",
                columns: table => new
                {
                    empid = table.Column<int>(type: "int", nullable: false),
                    projid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpProjs", x => new { x.empid, x.projid });
                    table.ForeignKey(
                        name: "FK_EmpProjs_Employees_empid",
                        column: x => x.empid,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpProjs_Projects_projid",
                        column: x => x.projid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpProjs_projid",
                table: "EmpProjs",
                column: "projid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpProjs");

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
    }
}
