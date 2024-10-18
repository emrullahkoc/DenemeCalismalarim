using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DenemeCalisma1.Migrations.FirstDbContext
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    SehirlerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirPlakasi = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.SehirlerID);
                });

            migrationBuilder.CreateTable(
                name: "Ilceler",
                columns: table => new
                {
                    IlcelerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlceAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirlerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilceler", x => x.IlcelerID);
                    table.ForeignKey(
                        name: "FK_Ilceler_Sehirler_SehirlerID",
                        column: x => x.SehirlerID,
                        principalTable: "Sehirler",
                        principalColumn: "SehirlerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Acenteler",
                columns: table => new
                {
                    AcenteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcenteAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeriTabaniServerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeriTabaniLogin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeriTabaniSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirlerID = table.Column<int>(type: "int", nullable: true),
                    IlcelerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acenteler", x => x.AcenteID);
                    table.ForeignKey(
                        name: "FK_Acenteler_Ilceler_IlcelerID",
                        column: x => x.IlcelerID,
                        principalTable: "Ilceler",
                        principalColumn: "IlcelerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Acenteler_Sehirler_SehirlerID",
                        column: x => x.SehirlerID,
                        principalTable: "Sehirler",
                        principalColumn: "SehirlerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acenteler_IlcelerID",
                table: "Acenteler",
                column: "IlcelerID");

            migrationBuilder.CreateIndex(
                name: "IX_Acenteler_SehirlerID",
                table: "Acenteler",
                column: "SehirlerID");

            migrationBuilder.CreateIndex(
                name: "IX_Ilceler_SehirlerID",
                table: "Ilceler",
                column: "SehirlerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acenteler");

            migrationBuilder.DropTable(
                name: "Ilceler");

            migrationBuilder.DropTable(
                name: "Sehirler");
        }
    }
}
