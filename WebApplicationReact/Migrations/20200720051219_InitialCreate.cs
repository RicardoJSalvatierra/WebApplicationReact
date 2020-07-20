using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationReact.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCarProps",
                columns: table => new
                {
                    IdCar = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patente = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Puertas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCarProps", x => x.IdCar);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCarProps");
        }
    }
}
