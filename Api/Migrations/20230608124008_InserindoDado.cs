using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoraAli.Api.Migrations
{
    /// <inheritdoc />
    public partial class InserindoDado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataCriacao", "Email", "Genero", "Idade", "Nome" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "victor@gmail.com", "Masculino", 22, "Victor" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
