using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KeyboardWIndowApp.Migrations
{
    public partial class madeDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Char",
                table: "Keyboard",
                nullable: true,
                oldClrType: typeof(char[]),
                oldType: "character(1)[]",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char[]>(
                name: "Char",
                table: "Keyboard",
                type: "character(1)[]",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
