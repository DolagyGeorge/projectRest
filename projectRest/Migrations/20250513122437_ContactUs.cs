using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectRest.Migrations
{
    /// <inheritdoc />
    public partial class ContactUs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Customers_CustomerID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_CustomerID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Customer_Email",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Customer_Name",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer_Email",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Customer_Name",
                table: "Contacts");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CustomerID",
                table: "Contacts",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Customers_CustomerID",
                table: "Contacts",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
