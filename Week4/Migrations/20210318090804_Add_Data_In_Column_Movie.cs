using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Week4.Migrations
{
    public partial class Add_Data_In_Column_Movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "ID", "Name", "Type", "Year" },
                values: new object[] { new Guid("76e99297-3b91-45f1-a281-df5bbe9931fa"), "Movie1", "Action", 2000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: new Guid("76e99297-3b91-45f1-a281-df5bbe9931fa"));
        }
    }
}
