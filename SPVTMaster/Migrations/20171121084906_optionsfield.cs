using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SPVTMaster.Migrations
{
    public partial class optionsfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Violation1",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Violation2",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Violation3",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Violation4",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Violation5",
                table: "Cars",
                newName: "Violation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Violation",
                table: "Cars",
                newName: "Violation5");

            migrationBuilder.AddColumn<string>(
                name: "Violation1",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Violation2",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Violation3",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Violation4",
                table: "Cars",
                nullable: true);
        }
    }
}
