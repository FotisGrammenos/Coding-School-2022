using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gas_Station.EF.Migrations
{
    public partial class ChanceEmployeeID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Employees_EmplouyeeID",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "EmplouyeeID",
                table: "Transactions",
                newName: "EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_EmplouyeeID",
                table: "Transactions",
                newName: "IX_Transactions_EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Employees_EmployeeID",
                table: "Transactions",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Employees_EmployeeID",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Transactions",
                newName: "EmplouyeeID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_EmployeeID",
                table: "Transactions",
                newName: "IX_Transactions_EmplouyeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Employees_EmplouyeeID",
                table: "Transactions",
                column: "EmplouyeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
