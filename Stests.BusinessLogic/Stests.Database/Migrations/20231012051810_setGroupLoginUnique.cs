using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stests.Database.Migrations
{
    /// <inheritdoc />
    public partial class setGroupLoginUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "UserGroups",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_Name",
                table: "UserGroups",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserGroups_Name",
                table: "UserGroups");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "UserGroups");
        }
    }
}
