using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gas_Station.EF.Migrations
{
    public partial class AddDiscountValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DiscountValue",
                table: "TransactionLines",
                type: "decimal(9,3)",
                precision: 9,
                scale: 3,
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountValue",
                table: "TransactionLines");
        }
    }
}
