using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SPVTMaster.Migrations
{
    public partial class radiobuttons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Category",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Category",
                newName: "ID");

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

            migrationBuilder.AddColumn<string>(
                name: "Violation5",
                table: "Cars",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Violation5",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Category",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Category",
                newName: "CategoryID");
        }
    }
}
