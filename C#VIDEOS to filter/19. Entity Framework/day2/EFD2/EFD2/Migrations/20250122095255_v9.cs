using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFD2.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "deptid",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_deptid",
                table: "Employees",
                column: "deptid");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_deptid",
                table: "Employees",
                column: "deptid",
                principalTable: "Departments",
                principalColumn: "deptid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_deptid",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_deptid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "deptid",
                table: "Employees");
        }
    }
}
