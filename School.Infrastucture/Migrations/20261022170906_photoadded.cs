using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class photoadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "StudentProfiles",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "StudentProfiles");
        }
    }
}
