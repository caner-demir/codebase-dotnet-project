using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Layered.DAL.Migrations
{
    public partial class Migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerProducts",
                table: "CustomerProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerProducts",
                table: "CustomerProducts",
                columns: new[] { "CustomerId", "ProductId", "Date" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerProducts",
                table: "CustomerProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerProducts",
                table: "CustomerProducts",
                columns: new[] { "CustomerId", "ProductId" });
        }
    }
}
