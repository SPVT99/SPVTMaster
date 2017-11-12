using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SPVTMaster.Migrations
{
    public partial class _500thtimetestingtextbox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextBox",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "Discription",
                table: "Cars",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discription",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "TextBox",
                table: "Cars",
                nullable: true);
        }
    }
}
