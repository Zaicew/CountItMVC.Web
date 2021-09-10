using Microsoft.EntityFrameworkCore.Migrations;

namespace CountItMVC.Infrastructure.Migrations
{
    public partial class migration09092021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Days_Customers_CustomerId",
                table: "Days");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Customers",
                newName: "IsActive");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Days",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Days",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Days_UserId",
                table: "Days",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Customers_CustomerId",
                table: "Days",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Days_AspNetUsers_UserId",
                table: "Days",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Days_Customers_CustomerId",
                table: "Days");

            migrationBuilder.DropForeignKey(
                name: "FK_Days_AspNetUsers_UserId",
                table: "Days");

            migrationBuilder.DropIndex(
                name: "IX_Days_UserId",
                table: "Days");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Days");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Customers",
                newName: "isActive");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Days",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Customers_CustomerId",
                table: "Days",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
