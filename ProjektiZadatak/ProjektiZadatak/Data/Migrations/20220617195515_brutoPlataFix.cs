using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektiZadatak.Data.Migrations
{
    public partial class brutoPlataFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "BrutoPlata",
                table: "Radnici",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrutoPlata",
                table: "Radnici");
        }
    }
}
