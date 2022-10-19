using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace KeyboardWIndowApp.Migrations
{
    public partial class madeDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Users_Login",
                table: "Users",
                column: "Login");

            migrationBuilder.CreateTable(
                name: "Difficulties",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Level = table.Column<int>(nullable: false),
                    ErrorPct = table.Column<int>(nullable: false),
                    MinLen = table.Column<int>(nullable: false),
                    MaxLen = table.Column<int>(nullable: false),
                    TypeSpeed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Difficulties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keyboard",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ZoneN = table.Column<string>(nullable: true),
                    Char = table.Column<char[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyboard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: false),
                    DifficultyId = table.Column<long>(nullable: false),
                    Len = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    IsRandom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                    table.UniqueConstraint("AK_Exercise_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Exercise_Difficulties_DifficultyId",
                        column: x => x.DifficultyId,
                        principalTable: "Difficulties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeZone",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DifficultyId = table.Column<long>(nullable: false),
                    KeyboardId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeZone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeZone_Difficulties_DifficultyId",
                        column: x => x.DifficultyId,
                        principalTable: "Difficulties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeZone_Keyboard_KeyboardId",
                        column: x => x.KeyboardId,
                        principalTable: "Keyboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TipeSpeed = table.Column<int>(nullable: false),
                    ErrorPct = table.Column<int>(nullable: false),
                    UsersId = table.Column<long>(nullable: false),
                    ExerciseId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statistics_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Statistics_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_DifficultyId",
                table: "Exercise",
                column: "DifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_ExerciseId",
                table: "Statistics",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_UsersId",
                table: "Statistics",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeZone_DifficultyId",
                table: "TypeZone",
                column: "DifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeZone_KeyboardId",
                table: "TypeZone",
                column: "KeyboardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "TypeZone");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Keyboard");

            migrationBuilder.DropTable(
                name: "Difficulties");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Users_Login",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
