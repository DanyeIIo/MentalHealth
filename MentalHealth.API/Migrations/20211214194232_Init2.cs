using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MentalHealth.API.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceWords_TestResults_TestResultId1",
                table: "ExperienceWords");

            migrationBuilder.DropIndex(
                name: "IX_ExperienceWords_TestResultId1",
                table: "ExperienceWords");

            migrationBuilder.DropColumn(
                name: "TestResultId1",
                table: "ExperienceWords");

            migrationBuilder.AlterColumn<Guid>(
                name: "TestResultId",
                table: "ExperienceWords",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceWords_TestResultId",
                table: "ExperienceWords",
                column: "TestResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceWords_TestResults_TestResultId",
                table: "ExperienceWords",
                column: "TestResultId",
                principalTable: "TestResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceWords_TestResults_TestResultId",
                table: "ExperienceWords");

            migrationBuilder.DropIndex(
                name: "IX_ExperienceWords_TestResultId",
                table: "ExperienceWords");

            migrationBuilder.AlterColumn<string>(
                name: "TestResultId",
                table: "ExperienceWords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "TestResultId1",
                table: "ExperienceWords",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceWords_TestResultId1",
                table: "ExperienceWords",
                column: "TestResultId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceWords_TestResults_TestResultId1",
                table: "ExperienceWords",
                column: "TestResultId1",
                principalTable: "TestResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
