using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DodatnaNaloga.Migrations
{
    public partial class adfad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {          
            migrationBuilder.CreateTable(
                name: "Uporabniki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UporabniskoIme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priimek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRojstva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Geslo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PonovnoGeslo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMSO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Starost = table.Column<int>(type: "int", nullable: false),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Posta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Drzava = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kraj = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uporabniki", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "avtorji");

            migrationBuilder.DropTable(
                name: "knjige");

            migrationBuilder.DropTable(
                name: "stranke");

            migrationBuilder.DropTable(
                name: "Uporabniki");
        }
    }
}
