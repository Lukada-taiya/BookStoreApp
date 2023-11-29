using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookstore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ObjectTableIdMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Book_BookIdpk",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderIdpk",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_BookIdpk",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "OrderIdpk",
                table: "OrderItem",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "BookIdpk",
                table: "OrderItem",
                newName: "BookIdfk");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderIdpk",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderId");

            migrationBuilder.RenameColumn(
                name: "BookIdpk",
                table: "BookDto",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_BookId",
                table: "OrderItem",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Book_BookId",
                table: "OrderItem",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "BookIdpk",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderIdpk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Book_BookId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_BookId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderItem",
                newName: "OrderIdpk");

            migrationBuilder.RenameColumn(
                name: "BookIdfk",
                table: "OrderItem",
                newName: "BookIdpk");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderIdpk");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BookDto",
                newName: "BookIdpk");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_BookIdpk",
                table: "OrderItem",
                column: "BookIdpk");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Book_BookIdpk",
                table: "OrderItem",
                column: "BookIdpk",
                principalTable: "Book",
                principalColumn: "BookIdpk",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderIdpk",
                table: "OrderItem",
                column: "OrderIdpk",
                principalTable: "Order",
                principalColumn: "OrderIdpk");
        }
    }
}
