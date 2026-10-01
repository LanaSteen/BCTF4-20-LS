using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class saxeli : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studios_Countries_CountryId",
                table: "Studios");

            migrationBuilder.AlterColumn<string>(
                name: "LicenseNumber",
                table: "StudioDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Studios_Countries_CountryId",
                table: "Studios",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studios_Countries_CountryId",
                table: "Studios");

            migrationBuilder.AlterColumn<string>(
                name: "LicenseNumber",
                table: "StudioDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_Studios_Countries_CountryId",
                table: "Studios",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
