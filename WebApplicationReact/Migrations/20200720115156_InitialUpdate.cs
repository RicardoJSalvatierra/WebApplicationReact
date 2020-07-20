using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationReact.Migrations
{
    public partial class InitialUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Titular",
                table: "tblCarProps",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titular",
                table: "tblCarProps");
        }
    }
}
