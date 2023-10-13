using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stests.Database.Migrations
{
    /// <inheritdoc />
    public partial class renameForPostgresOnceAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "users_answers",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "UserAnswer",
                table: "users_answers",
                newName: "user_answer");

            migrationBuilder.RenameColumn(
                name: "TestSessionId",
                table: "users_answers",
                newName: "test_session_id");

            migrationBuilder.RenameColumn(
                name: "TestId",
                table: "users_answers",
                newName: "test_id");

            migrationBuilder.RenameColumn(
                name: "UserAnswersId",
                table: "users_answers",
                newName: "user_answers_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "users",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "user_info",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "Patronymic",
                table: "user_info",
                newName: "patronymic");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "user_info",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "user_info",
                newName: "login");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "user_info",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "user_info",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "user_info",
                newName: "password_hash");

            migrationBuilder.RenameIndex(
                name: "IX_user_info_Login",
                table: "user_info",
                newName: "IX_user_info_login");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "user_groups",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "user_groups",
                newName: "password_hash");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "user_groups",
                newName: "group_id");

            migrationBuilder.RenameIndex(
                name: "IX_user_groups_Name",
                table: "user_groups",
                newName: "IX_user_groups_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "user_group_relation",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "user_group_relation",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "user_group_relation",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "user_group_relation",
                newName: "group_id");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "tests",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "TestQuestions",
                table: "tests",
                newName: "test_questions");

            migrationBuilder.RenameColumn(
                name: "TestName",
                table: "tests",
                newName: "test_name");

            migrationBuilder.RenameColumn(
                name: "TestId",
                table: "tests",
                newName: "test_id");

            migrationBuilder.RenameColumn(
                name: "TestId",
                table: "test_sessions",
                newName: "test_id");

            migrationBuilder.RenameColumn(
                name: "SessionStart",
                table: "test_sessions",
                newName: "session_start");

            migrationBuilder.RenameColumn(
                name: "SessionName",
                table: "test_sessions",
                newName: "session_name");

            migrationBuilder.RenameColumn(
                name: "SessionEnd",
                table: "test_sessions",
                newName: "session_end");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "test_sessions",
                newName: "group_id");

            migrationBuilder.RenameColumn(
                name: "TestSessionId",
                table: "test_sessions",
                newName: "test_session_id");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "roles",
                newName: "role_name");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "roles",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "Grade",
                table: "grades",
                newName: "grade");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "grades",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "TestSessionId",
                table: "grades",
                newName: "test_session_id");

            migrationBuilder.RenameColumn(
                name: "TestId",
                table: "grades",
                newName: "test_id");

            migrationBuilder.RenameColumn(
                name: "GradeId",
                table: "grades",
                newName: "grade_id");

            migrationBuilder.RenameColumn(
                name: "TestId",
                table: "correct_answers",
                newName: "test_id");

            migrationBuilder.RenameColumn(
                name: "CorrectAnswersJson",
                table: "correct_answers",
                newName: "correct_answers_json");

            migrationBuilder.RenameColumn(
                name: "CorrectAnswersId",
                table: "correct_answers",
                newName: "сorrect_answers_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "users_answers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "user_answer",
                table: "users_answers",
                newName: "UserAnswer");

            migrationBuilder.RenameColumn(
                name: "test_session_id",
                table: "users_answers",
                newName: "TestSessionId");

            migrationBuilder.RenameColumn(
                name: "test_id",
                table: "users_answers",
                newName: "TestId");

            migrationBuilder.RenameColumn(
                name: "user_answers_id",
                table: "users_answers",
                newName: "UserAnswersId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "surname",
                table: "user_info",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "patronymic",
                table: "user_info",
                newName: "Patronymic");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "user_info",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "login",
                table: "user_info",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "user_info",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "user_info",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "user_info",
                newName: "PasswordHash");

            migrationBuilder.RenameIndex(
                name: "IX_user_info_login",
                table: "user_info",
                newName: "IX_user_info_Login");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "user_groups",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "user_groups",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "user_groups",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_user_groups_name",
                table: "user_groups",
                newName: "IX_user_groups_Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "user_group_relation",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "user_group_relation",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "user_group_relation",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "user_group_relation",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "tests",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "test_questions",
                table: "tests",
                newName: "TestQuestions");

            migrationBuilder.RenameColumn(
                name: "test_name",
                table: "tests",
                newName: "TestName");

            migrationBuilder.RenameColumn(
                name: "test_id",
                table: "tests",
                newName: "TestId");

            migrationBuilder.RenameColumn(
                name: "test_id",
                table: "test_sessions",
                newName: "TestId");

            migrationBuilder.RenameColumn(
                name: "session_start",
                table: "test_sessions",
                newName: "SessionStart");

            migrationBuilder.RenameColumn(
                name: "session_name",
                table: "test_sessions",
                newName: "SessionName");

            migrationBuilder.RenameColumn(
                name: "session_end",
                table: "test_sessions",
                newName: "SessionEnd");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "test_sessions",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "test_session_id",
                table: "test_sessions",
                newName: "TestSessionId");

            migrationBuilder.RenameColumn(
                name: "role_name",
                table: "roles",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "roles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "grade",
                table: "grades",
                newName: "Grade");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "grades",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "test_session_id",
                table: "grades",
                newName: "TestSessionId");

            migrationBuilder.RenameColumn(
                name: "test_id",
                table: "grades",
                newName: "TestId");

            migrationBuilder.RenameColumn(
                name: "grade_id",
                table: "grades",
                newName: "GradeId");

            migrationBuilder.RenameColumn(
                name: "test_id",
                table: "correct_answers",
                newName: "TestId");

            migrationBuilder.RenameColumn(
                name: "correct_answers_json",
                table: "correct_answers",
                newName: "CorrectAnswersJson");

            migrationBuilder.RenameColumn(
                name: "сorrect_answers_id",
                table: "correct_answers",
                newName: "CorrectAnswersId");
        }
    }
}
