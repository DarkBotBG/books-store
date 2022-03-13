using Microsoft.EntityFrameworkCore.Migrations;

namespace _5_3_2022.Migrations
{
    public partial class books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Knigi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 10, nullable: true),
                    Author = table.Column<string>(maxLength: 10, nullable: true),
                    Publisher = table.Column<string>(maxLength: 10, nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knigi", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Knigi");
        }
    }
}
