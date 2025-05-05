using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectRest.Migrations
{
    /// <inheritdoc />
    public partial class deletedPriceFromOrderp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderProducts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "OrderProducts",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
