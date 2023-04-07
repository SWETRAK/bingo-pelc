using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BingoPelc.Migrations
{
    /// <inheritdoc />
    public partial class Createdadminuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "daily_bingo",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 6, 21, 31, 20, 333, DateTimeKind.Local).AddTicks(3910),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 4, 21, 51, 4, 234, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "HashedPassword", "Nickname" },
                values: new object[] { new Guid("77318190-c9cf-4568-aa0e-374bfa958823"), "kamilpietrak123@gmail.com", "AQAAAAIAAYagAAAAEDkMuHLJn58ej1h3jD/A8Q4CHD3pc2fOi647e2fEn+FsDIp8LjqNbUFlgPPZ9U+vLg==", "SWETRAK" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("77318190-c9cf-4568-aa0e-374bfa958823"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "daily_bingo",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 4, 21, 51, 4, 234, DateTimeKind.Local).AddTicks(8560),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 6, 21, 31, 20, 333, DateTimeKind.Local).AddTicks(3910));
        }
    }
}
