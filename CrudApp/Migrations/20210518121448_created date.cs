using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudApp.Migrations
{
    public partial class createddate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
