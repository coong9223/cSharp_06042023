using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanGiay_ASP_c4.Migrations
{
    public partial class DBSet2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkAnh",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkAnh",
                table: "Products");
        }
    }
}
