using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BingoPelc.Migrations
{
    /// <inheritdoc />
    public partial class Createdinitialquestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("77318190-c9cf-4568-aa0e-374bfa958823"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "daily_bingo",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 6, 21, 54, 41, 644, DateTimeKind.Local).AddTicks(1940),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 6, 21, 31, 20, 333, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.InsertData(
                table: "question",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("0ab85131-48c3-404c-9eed-a855971882a9"), "Dojeżdżam na polibudę zaraz" },
                    { new Guid("0d4ed133-66b0-4fce-8016-4e45dbc909c5"), "Wyjechać z tej mojej wsi" },
                    { new Guid("0e9c414d-f417-45ab-a545-d5e334886a7f"), "Nie stać mnie" },
                    { new Guid("11253e13-111e-4c96-94a5-9b0139df5d5b"), "Więcej czasu na tej jebanej uczelni spędzam niż w domu" },
                    { new Guid("11d40587-6967-4a91-b73e-35503e63a824"), "Kiedyś ci oddam bo nie mam teraz" },
                    { new Guid("155f4842-2085-4534-af1e-eb734f63d909"), "No kurde stary, zanim ja pojade do domu i wróce to 3 godziny mijają" },
                    { new Guid("2c939ec9-c5c0-4383-821a-fbdab27ff964"), "Jak mi zapłacicie za bolta, to mogę opić" },
                    { new Guid("3455201e-dc7c-4e93-b7b0-04c1db816ece"), "Rowerem przyjechałem" },
                    { new Guid("34c06a52-b836-4c6f-b4a3-5169409ceee1"), "Rada wydziału" },
                    { new Guid("37e669b7-6ab8-431a-a30f-1a3114ae7ce8"), "Przepraszam za spóźnienie" },
                    { new Guid("50dfe03e-bb3a-49b5-8827-b40876ab5599"), "Autobus nie przyjechał" },
                    { new Guid("51731f78-2e7a-4183-94f5-6b0822694cef"), "Czego tak?" },
                    { new Guid("52818c27-b38c-41aa-83f6-db7c828ce8fc"), "To co może po piwerku" },
                    { new Guid("6419bf9b-afc0-4237-b2ba-f50f707d73dd"), "Korki były" },
                    { new Guid("66f7e376-f71e-49cd-bc88-7a52b0b7dc80"), "Ja odpuszczam wykłady, idę do Kazika" },
                    { new Guid("6ab3824d-97ed-452b-b4bc-414f6aed3cd5"), "Alkochol w plecaku/torbie" },
                    { new Guid("6e19b675-408f-4e03-bee1-8dff719c9ae7"), "Mam spotkanie samorządu" },
                    { new Guid("7bc213fd-65a6-446e-92b7-e1447e7bd3a7"), "Ja przyniosę zwolniennie na następne zajęcia" },
                    { new Guid("868bda23-4e07-44e8-8da3-cb0081934b6d"), "Sprawdzam wnioski stypendialne" },
                    { new Guid("8962d7cc-449a-483d-8861-c24e1dc8adce"), "EHE HE HE" },
                    { new Guid("bb4b912c-4ac2-410b-a64c-83685332dd30"), "Chodźmy do Kazika" },
                    { new Guid("bf62a012-6d18-496b-bccc-5fb749a03a7e"), "Kupiłem monstera za x ziko, ale mi się zwróci" },
                    { new Guid("d18e7181-c1fb-4797-8d15-f207743c069e"), "Urodziny" },
                    { new Guid("d8628687-2ba5-4562-9cda-faab492cc596"), "Zachlałem" },
                    { new Guid("f78bfdd1-b1da-46ee-b4b2-63f4108cb140"), "Nie chciało mi się " }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "HashedPassword", "Nickname" },
                values: new object[] { new Guid("35cb142f-5112-4d69-9c5c-6b4750362403"), "kamilpietrak123@gmail.com", "AQAAAAIAAYagAAAAECToVyUDqC/F0ti0zdYO8cyLYZ+PskefLPix6KfJZX3F/+ZrsPH7BGz7RJVM+QieeA==", "SWETRAK" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("0ab85131-48c3-404c-9eed-a855971882a9"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("0d4ed133-66b0-4fce-8016-4e45dbc909c5"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("0e9c414d-f417-45ab-a545-d5e334886a7f"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("11253e13-111e-4c96-94a5-9b0139df5d5b"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("11d40587-6967-4a91-b73e-35503e63a824"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("155f4842-2085-4534-af1e-eb734f63d909"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("2c939ec9-c5c0-4383-821a-fbdab27ff964"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("3455201e-dc7c-4e93-b7b0-04c1db816ece"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("34c06a52-b836-4c6f-b4a3-5169409ceee1"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("37e669b7-6ab8-431a-a30f-1a3114ae7ce8"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("50dfe03e-bb3a-49b5-8827-b40876ab5599"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("51731f78-2e7a-4183-94f5-6b0822694cef"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("52818c27-b38c-41aa-83f6-db7c828ce8fc"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("6419bf9b-afc0-4237-b2ba-f50f707d73dd"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("66f7e376-f71e-49cd-bc88-7a52b0b7dc80"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("6ab3824d-97ed-452b-b4bc-414f6aed3cd5"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("6e19b675-408f-4e03-bee1-8dff719c9ae7"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("7bc213fd-65a6-446e-92b7-e1447e7bd3a7"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("868bda23-4e07-44e8-8da3-cb0081934b6d"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("8962d7cc-449a-483d-8861-c24e1dc8adce"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("bb4b912c-4ac2-410b-a64c-83685332dd30"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("bf62a012-6d18-496b-bccc-5fb749a03a7e"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("d18e7181-c1fb-4797-8d15-f207743c069e"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("d8628687-2ba5-4562-9cda-faab492cc596"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("f78bfdd1-b1da-46ee-b4b2-63f4108cb140"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("35cb142f-5112-4d69-9c5c-6b4750362403"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "daily_bingo",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 6, 21, 31, 20, 333, DateTimeKind.Local).AddTicks(3910),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 6, 21, 54, 41, 644, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "HashedPassword", "Nickname" },
                values: new object[] { new Guid("77318190-c9cf-4568-aa0e-374bfa958823"), "kamilpietrak123@gmail.com", "AQAAAAIAAYagAAAAEDkMuHLJn58ej1h3jD/A8Q4CHD3pc2fOi647e2fEn+FsDIp8LjqNbUFlgPPZ9U+vLg==", "SWETRAK" });
        }
    }
}
