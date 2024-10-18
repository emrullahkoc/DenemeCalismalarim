using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DenemeCalisma1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateForAnaDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acents",
                columns: table => new
                {
                    AcenteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcenteAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeriTabaniServerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeriTabaniLogin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeriTabaniSifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acents", x => x.AcenteID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acents");
        }
    }
}
