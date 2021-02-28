using Microsoft.EntityFrameworkCore.Migrations;

namespace MtNews.Migrations
{
    public partial class EditAgencyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubType",
                table: "Agencies",
                newName: "MtType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MtType",
                table: "Agencies",
                newName: "SubType");
        }
    }
}
