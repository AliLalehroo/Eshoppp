using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshop.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditVariant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_ProductColors_ProductColorId",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "buyer_ip",
                table: "PaymentRecords");

            migrationBuilder.RenameColumn(
                name: "authority",
                table: "PaymentRecords",
                newName: "Authority");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "PaymentRecords",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "trans_id",
                table: "PaymentRecords",
                newName: "TransactionId");

            migrationBuilder.RenameColumn(
                name: "ref_id",
                table: "PaymentRecords",
                newName: "RefId");

            migrationBuilder.RenameColumn(
                name: "payment_time",
                table: "PaymentRecords",
                newName: "PaymentTime");

            migrationBuilder.RenameColumn(
                name: "invoice_id",
                table: "PaymentRecords",
                newName: "CardPan");

            migrationBuilder.RenameColumn(
                name: "card_pan",
                table: "PaymentRecords",
                newName: "BuyerId");

            migrationBuilder.AlterColumn<long>(
                name: "ProductColorId",
                table: "ProductVariants",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "ColorCode",
                table: "ProductVariants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ColorTitle",
                table: "ProductVariants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "InvoiceId",
                table: "PaymentRecords",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_ProductColors_ProductColorId",
                table: "ProductVariants",
                column: "ProductColorId",
                principalTable: "ProductColors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_ProductColors_ProductColorId",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "ColorCode",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "ColorTitle",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "PaymentRecords");

            migrationBuilder.RenameColumn(
                name: "Authority",
                table: "PaymentRecords",
                newName: "authority");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "PaymentRecords",
                newName: "amount");

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "PaymentRecords",
                newName: "trans_id");

            migrationBuilder.RenameColumn(
                name: "RefId",
                table: "PaymentRecords",
                newName: "ref_id");

            migrationBuilder.RenameColumn(
                name: "PaymentTime",
                table: "PaymentRecords",
                newName: "payment_time");

            migrationBuilder.RenameColumn(
                name: "CardPan",
                table: "PaymentRecords",
                newName: "invoice_id");

            migrationBuilder.RenameColumn(
                name: "BuyerId",
                table: "PaymentRecords",
                newName: "card_pan");

            migrationBuilder.AlterColumn<long>(
                name: "ProductColorId",
                table: "ProductVariants",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "buyer_ip",
                table: "PaymentRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_ProductColors_ProductColorId",
                table: "ProductVariants",
                column: "ProductColorId",
                principalTable: "ProductColors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
