using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DenemeCalisma1.Migrations.Tt
{
    /// <inheritdoc />
    public partial class InitialCreateForTtDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullacilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdiSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifresi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullacilar", x => x.KullaniciID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullacilar");
        }
    }
}
