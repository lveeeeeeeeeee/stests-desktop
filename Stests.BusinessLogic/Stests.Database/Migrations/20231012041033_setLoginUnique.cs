using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stests.Database.Migrations
{
    /// <inheritdoc />
    public partial class setLoginUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_Login",
                table: "UserInfo",
                column: "Login",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserInfo_Login",
                table: "UserInfo");
        }
    }
}
