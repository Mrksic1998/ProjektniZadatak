using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektiZadatak.Data.Migrations
{
    public partial class dodatoIzracunavanjeBruto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Radnici",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Radnici",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adresa",
                table: "Radnici",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PNZP",
                table: "Radnici",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PPIO",
                table: "Radnici",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PZDR",
                table: "Radnici",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RNZP",
                table: "Radnici",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RPIO",
                table: "Radnici",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RZDR",
                table: "Radnici",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "StopaPoreza",
                table: "Radnici",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PNZP",
                table: "Radnici");

            migrationBuilder.DropColumn(
                name: "PPIO",
                table: "Radnici");

            migrationBuilder.DropColumn(
                name: "PZDR",
                table: "Radnici");

            migrationBuilder.DropColumn(
                name: "RNZP",
                table: "Radnici");

            migrationBuilder.DropColumn(
                name: "RPIO",
                table: "Radnici");

            migrationBuilder.DropColumn(
                name: "RZDR",
                table: "Radnici");

            migrationBuilder.DropColumn(
                name: "StopaPoreza",
                table: "Radnici");

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Radnici",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Radnici",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adresa",
                table: "Radnici",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
