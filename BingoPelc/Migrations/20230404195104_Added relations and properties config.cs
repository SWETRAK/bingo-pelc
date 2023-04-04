using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BingoPelc.Migrations
{
    /// <inheritdoc />
    public partial class Addedrelationsandpropertiesconfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyBingos_Users_UserId",
                table: "DailyBingos");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyQuestions_DailyBingos_DailyBingoId",
                table: "DailyQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyQuestions_Questions_QuestionId",
                table: "DailyQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DailyQuestions",
                table: "DailyQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DailyBingos",
                table: "DailyBingos");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "question");

            migrationBuilder.RenameTable(
                name: "DailyQuestions",
                newName: "daily_questions");

            migrationBuilder.RenameTable(
                name: "DailyBingos",
                newName: "daily_bingo");

            migrationBuilder.RenameIndex(
                name: "IX_DailyQuestions_QuestionId",
                table: "daily_questions",
                newName: "IX_daily_questions_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyQuestions_DailyBingoId",
                table: "daily_questions",
                newName: "IX_daily_questions_DailyBingoId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyBingos_UserId",
                table: "daily_bingo",
                newName: "IX_daily_bingo_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Nickname",
                table: "users",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HashedPassword",
                table: "users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "question",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Checked",
                table: "daily_questions",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "daily_bingo",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 4, 21, 51, 4, 234, DateTimeKind.Local).AddTicks(8560),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_question",
                table: "question",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_daily_questions",
                table: "daily_questions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_daily_bingo",
                table: "daily_bingo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_daily_bingo_users_UserId",
                table: "daily_bingo",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_daily_questions_daily_bingo_DailyBingoId",
                table: "daily_questions",
                column: "DailyBingoId",
                principalTable: "daily_bingo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_daily_questions_question_QuestionId",
                table: "daily_questions",
                column: "QuestionId",
                principalTable: "question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_daily_bingo_users_UserId",
                table: "daily_bingo");

            migrationBuilder.DropForeignKey(
                name: "FK_daily_questions_daily_bingo_DailyBingoId",
                table: "daily_questions");

            migrationBuilder.DropForeignKey(
                name: "FK_daily_questions_question_QuestionId",
                table: "daily_questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_question",
                table: "question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_daily_questions",
                table: "daily_questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_daily_bingo",
                table: "daily_bingo");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "daily_questions",
                newName: "DailyQuestions");

            migrationBuilder.RenameTable(
                name: "daily_bingo",
                newName: "DailyBingos");

            migrationBuilder.RenameIndex(
                name: "IX_daily_questions_QuestionId",
                table: "DailyQuestions",
                newName: "IX_DailyQuestions_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_daily_questions_DailyBingoId",
                table: "DailyQuestions",
                newName: "IX_DailyQuestions_DailyBingoId");

            migrationBuilder.RenameIndex(
                name: "IX_daily_bingo_UserId",
                table: "DailyBingos",
                newName: "IX_DailyBingos_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Nickname",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "HashedPassword",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Questions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "Checked",
                table: "DailyQuestions",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "DailyBingos",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 4, 21, 51, 4, 234, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailyQuestions",
                table: "DailyQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailyBingos",
                table: "DailyBingos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyBingos_Users_UserId",
                table: "DailyBingos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyQuestions_DailyBingos_DailyBingoId",
                table: "DailyQuestions",
                column: "DailyBingoId",
                principalTable: "DailyBingos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyQuestions_Questions_QuestionId",
                table: "DailyQuestions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
