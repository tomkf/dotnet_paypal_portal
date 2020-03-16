using Microsoft.EntityFrameworkCore.Migrations;

namespace paypal_final.Data.Migrations
{
    public partial class DbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IPNs",
                columns: table => new
                {
                    paymentID = table.Column<string>(nullable: false),
                    custom = table.Column<string>(nullable: true),
                    cart = table.Column<string>(nullable: true),
                    create_time = table.Column<string>(nullable: true),
                    payerID = table.Column<string>(nullable: true),
                    payerFirstName = table.Column<string>(nullable: true),
                    payerLastName = table.Column<string>(nullable: true),
                    payerMiddleName = table.Column<string>(nullable: true),
                    payerEmail = table.Column<string>(nullable: true),
                    payerCountryCode = table.Column<string>(nullable: true),
                    payerStatus = table.Column<string>(nullable: true),
                    amount = table.Column<string>(nullable: true),
                    currency = table.Column<string>(nullable: true),
                    intent = table.Column<string>(nullable: true),
                    paymentMethod = table.Column<string>(nullable: true),
                    paymentState = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPNs", x => x.paymentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IPNs");
        }
    }
}
