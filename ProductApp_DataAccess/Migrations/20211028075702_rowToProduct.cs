using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductApp_DataAccess.Migrations
{
    public partial class rowToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Products Values(' Product 1 ','1000','23')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
