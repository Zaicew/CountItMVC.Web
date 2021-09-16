using Microsoft.EntityFrameworkCore.Migrations;

namespace CountItMVC.Infrastructure.Migrations
{
    public partial class _09162021_1413 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalCarb",
                table: "Meals",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalFat",
                table: "Meals",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalKcal",
                table: "Meals",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalProtein",
                table: "Meals",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalWeight",
                table: "Meals",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCarb",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "TotalFat",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "TotalKcal",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "TotalProtein",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "TotalWeight",
                table: "Meals");
        }
    }
}
