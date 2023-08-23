using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementPanelProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addexperienceyear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExperienceYear",
                table: "Users",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExperienceYear",
                table: "Users");
        }
    }
}
