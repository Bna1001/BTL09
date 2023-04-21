using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baitaplonnhom09.Migrations
{
    /// <inheritdoc />
    public partial class CeoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountID = table.Column<string>(type: "TEXT", nullable: false),
                    AccountName = table.Column<string>(type: "TEXT", nullable: false),
                    AccountPosition = table.Column<string>(type: "TEXT", nullable: false),
                    AccountEarn = table.Column<string>(type: "TEXT", nullable: false),
                    AccountPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    AccountAddress = table.Column<string>(type: "TEXT", nullable: false),
                    AccountBirth = table.Column<string>(type: "TEXT", nullable: false),
                    AccountSex = table.Column<string>(type: "TEXT", nullable: false),
                    AccountBank = table.Column<string>(type: "TEXT", nullable: false),
                    AccountStart = table.Column<string>(type: "TEXT", nullable: false),
                    AccountEnd = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "Ceo",
                columns: table => new
                {
                    CeoID = table.Column<string>(type: "TEXT", nullable: false),
                    CeoName = table.Column<string>(type: "TEXT", nullable: false),
                    CeoPosition = table.Column<string>(type: "TEXT", nullable: false),
                    CeoEarn = table.Column<string>(type: "TEXT", nullable: false),
                    CeoPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CeoAddress = table.Column<string>(type: "TEXT", nullable: false),
                    CeoBirth = table.Column<string>(type: "TEXT", nullable: false),
                    CeoSex = table.Column<string>(type: "TEXT", nullable: false),
                    CeoBank = table.Column<string>(type: "TEXT", nullable: false),
                    CeoStart = table.Column<string>(type: "TEXT", nullable: false),
                    CeoEnd = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ceo", x => x.CeoID);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    SaleID = table.Column<string>(type: "TEXT", nullable: false),
                    SaleName = table.Column<string>(type: "TEXT", nullable: false),
                    SalePosition = table.Column<string>(type: "TEXT", nullable: false),
                    SaleEarn = table.Column<string>(type: "TEXT", nullable: false),
                    SalePhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    SaleAddress = table.Column<string>(type: "TEXT", nullable: false),
                    SaleBirth = table.Column<string>(type: "TEXT", nullable: false),
                    SaleSex = table.Column<string>(type: "TEXT", nullable: false),
                    SaleBank = table.Column<string>(type: "TEXT", nullable: false),
                    SaleStart = table.Column<string>(type: "TEXT", nullable: false),
                    SaleEnd = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.SaleID);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<string>(type: "TEXT", nullable: false),
                    StaffName = table.Column<string>(type: "TEXT", nullable: false),
                    StaffPosition = table.Column<string>(type: "TEXT", nullable: false),
                    StaffEarn = table.Column<string>(type: "TEXT", nullable: false),
                    StaffPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    StaffAddress = table.Column<string>(type: "TEXT", nullable: false),
                    StaffBirth = table.Column<string>(type: "TEXT", nullable: false),
                    StaffSex = table.Column<string>(type: "TEXT", nullable: false),
                    StaffBank = table.Column<string>(type: "TEXT", nullable: false),
                    StaffStart = table.Column<string>(type: "TEXT", nullable: false),
                    StaffEnd = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Ceo");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
