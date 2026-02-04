using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshop.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "ProductSells",
                newName: "ProductPrice");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "OrderDetails",
                newName: "VariantPrice");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "ProductSells",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductPrice",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPrice",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "ProductSells");

            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "ProductPrice",
                table: "ProductSells",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "VariantPrice",
                table: "OrderDetails",
                newName: "Price");
        }
    }
}
