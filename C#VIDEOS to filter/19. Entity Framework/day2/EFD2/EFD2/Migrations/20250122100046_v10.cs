using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFD2.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "did",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_did",
                table: "Employees",
                column: "did");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_did",
                table: "Employees",
                column: "did",
                principalTable: "Departments",
                principalColumn: "deptid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_did",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_did",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "did",
                table: "Employees");

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
    }
}
