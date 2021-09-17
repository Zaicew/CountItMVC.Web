using Microsoft.EntityFrameworkCore.Migrations;

namespace CountItMVC.Infrastructure.Migrations
{
    public partial class _09172021_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Meals",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalCarbs",
                table: "Days",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalFat",
                table: "Days",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalKcal",
                table: "Days",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalProtein",
                table: "Days",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalWeightInGram",
                table: "Days",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "TotalCarbs",
                table: "Days");

            migrationBuilder.DropColumn(
                name: "TotalFat",
                table: "Days");

            migrationBuilder.DropColumn(
                name: "TotalKcal",
                table: "Days");

            migrationBuilder.DropColumn(
                name: "TotalProtein",
                table: "Days");

            migrationBuilder.DropColumn(
                name: "TotalWeightInGram",
                table: "Days");
        }
    }
}
