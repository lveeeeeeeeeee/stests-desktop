using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stests.Database.Migrations
{
    /// <inheritdoc />
    public partial class renameForPostgres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grades",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersAnswers",
                table: "UsersAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserGroups",
                table: "UserGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserGroupRelation",
                table: "UserGroupRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestSessions",
                table: "TestSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CorrectAnswers",
                table: "CorrectAnswers");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Tests",
                newName: "tests");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "roles");

            migrationBuilder.RenameTable(
                name: "Grades",
                newName: "grades");

            migrationBuilder.RenameTable(
                name: "UsersAnswers",
                newName: "users_answers");

            migrationBuilder.RenameTable(
                name: "UserInfo",
                newName: "user_info");

            migrationBuilder.RenameTable(
                name: "UserGroups",
                newName: "user_groups");

            migrationBuilder.RenameTable(
                name: "UserGroupRelation",
                newName: "user_group_relation");

            migrationBuilder.RenameTable(
                name: "TestSessions",
                newName: "test_sessions");

            migrationBuilder.RenameTable(
                name: "CorrectAnswers",
                newName: "correct_answers");

            migrationBuilder.RenameIndex(
                name: "IX_UserInfo_Login",
                table: "user_info",
                newName: "IX_user_info_Login");

            migrationBuilder.RenameIndex(
                name: "IX_UserGroups_Name",
                table: "user_groups",
                newName: "IX_user_groups_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tests",
                table: "tests",
                column: "TestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roles",
                table: "roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_grades",
                table: "grades",
                column: "GradeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users_answers",
                table: "users_answers",
                column: "UserAnswersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_info",
                table: "user_info",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_groups",
                table: "user_groups",
                column: "GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_group_relation",
                table: "user_group_relation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_test_sessions",
                table: "test_sessions",
                column: "TestSessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_correct_answers",
                table: "correct_answers",
                column: "CorrectAnswersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tests",
                table: "tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_roles",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_grades",
                table: "grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users_answers",
                table: "users_answers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_info",
                table: "user_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_groups",
                table: "user_groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_group_relation",
                table: "user_group_relation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_test_sessions",
                table: "test_sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_correct_answers",
                table: "correct_answers");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "tests",
                newName: "Tests");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "grades",
                newName: "Grades");

            migrationBuilder.RenameTable(
                name: "users_answers",
                newName: "UsersAnswers");

            migrationBuilder.RenameTable(
                name: "user_info",
                newName: "UserInfo");

            migrationBuilder.RenameTable(
                name: "user_groups",
                newName: "UserGroups");

            migrationBuilder.RenameTable(
                name: "user_group_relation",
                newName: "UserGroupRelation");

            migrationBuilder.RenameTable(
                name: "test_sessions",
                newName: "TestSessions");

            migrationBuilder.RenameTable(
                name: "correct_answers",
                newName: "CorrectAnswers");

            migrationBuilder.RenameIndex(
                name: "IX_user_info_Login",
                table: "UserInfo",
                newName: "IX_UserInfo_Login");

            migrationBuilder.RenameIndex(
                name: "IX_user_groups_Name",
                table: "UserGroups",
                newName: "IX_UserGroups_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                column: "TestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grades",
                table: "Grades",
                column: "GradeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersAnswers",
                table: "UsersAnswers",
                column: "UserAnswersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserGroups",
                table: "UserGroups",
                column: "GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserGroupRelation",
                table: "UserGroupRelation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestSessions",
                table: "TestSessions",
                column: "TestSessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CorrectAnswers",
                table: "CorrectAnswers",
                column: "CorrectAnswersId");
        }
    }
}
