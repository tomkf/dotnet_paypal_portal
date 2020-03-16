using Microsoft.EntityFrameworkCore.Migrations;

namespace paypal_final.Data.Migrations
{
    public partial class AdditionalFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "finalAmount",
                table: "IPNs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "quantity",
                table: "IPNs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "unitPrice",
                table: "IPNs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "finalAmount",
                table: "IPNs");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "IPNs");

            migrationBuilder.DropColumn(
                name: "unitPrice",
                table: "IPNs");
        }
    }
}
