using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abouts",
                columns: table => new
                {
                    aboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aboutValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutImagePath = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouts", x => x.aboutId);
                });

            migrationBuilder.CreateTable(
                name: "companyServices",
                columns: table => new
                {
                    companyServicesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyServicesHeader = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    companyServicesDescription = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyServices", x => x.companyServicesId);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    contactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    senderName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    senderSurname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    senderMail = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.contactId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abouts");

            migrationBuilder.DropTable(
                name: "companyServices");

            migrationBuilder.DropTable(
                name: "contacts");
        }
    }
}
