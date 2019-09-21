using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastroclientes.Migrations
{
    public partial class Cadastro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "cadastro");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "cadastro");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "cadastro",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "cadastro",
                newName: "Nome");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "cadastro",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "cadastro",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "cadastro",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "cadastro",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "cadastro");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "cadastro");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "cadastro");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "cadastro");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "cadastro",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "cadastro",
                newName: "Genre");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "cadastro",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "cadastro",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
