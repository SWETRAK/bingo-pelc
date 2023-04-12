using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BingoPelc.Migrations
{
    /// <inheritdoc />
    public partial class AddedwinfieldtoDailyBingo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 6, 21, 54, 41, 644, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.AddColumn<bool>(
                name: "Win",
                table: "daily_bingo",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "question",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("005c89ea-4249-4b11-a614-0ef68fdc8969"), "Autobus nie przyjechał" },
                    { new Guid("03aeb449-7fbd-4a07-81b4-fc7434c3f50a"), "Alkochol w plecaku/torbie" },
                    { new Guid("1b16d714-1878-47df-8b7e-a6b1e9803fdd"), "Więcej czasu na tej jebanej uczelni spędzam niż w domu" },
                    { new Guid("1cba8b00-58fd-42f1-bf94-237cbb8ba508"), "To co może po piwerku" },
                    { new Guid("1cd7c9f4-499f-4718-90b5-d21da8a326f2"), "Nie chciało mi się " },
                    { new Guid("20c0532b-c30f-4067-9147-23efda3ddb26"), "Sprawdzam wnioski stypendialne" },
                    { new Guid("46f6464c-826d-4dd7-bf27-ea7fec9fa50e"), "Mam spotkanie samorządu" },
                    { new Guid("4a0144ef-00ce-45e1-980b-637c6c6d00ef"), "Kiedyś ci oddam bo nie mam teraz" },
                    { new Guid("5d11b477-7fa2-432d-9a29-9937fecb5412"), "Wyjechać z tej mojej wsi" },
                    { new Guid("6623c99b-003d-4fbb-9812-0d0686efbf10"), "Nie stać mnie" },
                    { new Guid("7aa0100e-d9fd-45a9-b7b9-cbabf49c6e69"), "EHE HE HE" },
                    { new Guid("7bd09eee-7cf5-441c-8cad-6cca43c06f40"), "Czego tak?" },
                    { new Guid("81450962-8e6e-4f0b-9dd9-0206e1ea1d30"), "Ja odpuszczam wykłady, idę do Kazika" },
                    { new Guid("82efc76e-5fb8-49b6-8b7a-89a35c1d2f7e"), "Rada wydziału" },
                    { new Guid("894e8410-f5ee-458a-bfb2-c0c898377d7a"), "Zachlałem" },
                    { new Guid("8bcb6155-3412-4ee6-9562-1f5d2b8cdec1"), "Urodziny" },
                    { new Guid("a7003e43-6dfd-42bb-b2ff-c0d20d32db93"), "Kupiłem monstera za x ziko, ale mi się zwróci" },
                    { new Guid("b1908bc6-dd7a-48b9-8426-48d3c5de350f"), "Korki były" },
                    { new Guid("b8300a76-4e84-4f19-a0d9-426930fafff4"), "Dojeżdżam na polibudę zaraz" },
                    { new Guid("bf65a9bc-c149-412d-a8b9-a0eb25267b99"), "Jak mi zapłacicie za bolta, to mogę opić" },
                    { new Guid("d5936d12-69b4-4a43-b83d-904273687828"), "Chodźmy do Kazika" },
                    { new Guid("ddfc9adf-cefd-4479-99c3-5e2f73087360"), "Przepraszam za spóźnienie" },
                    { new Guid("e32f1964-f233-4103-abf9-e9fc40c907ca"), "Ja przyniosę zwolniennie na następne zajęcia" },
                    { new Guid("f240460a-70ca-4c51-94be-288b00443ccc"), "No kurde stary, zanim ja pojade do domu i wróce to 3 godziny mijają" },
                    { new Guid("fc5f08a9-0228-4fd7-b9bb-c3bd08b85901"), "Rowerem przyjechałem" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "HashedPassword", "Nickname" },
                values: new object[] { new Guid("bf04cada-2d88-404c-a66a-3614f9edbc16"), "kamilpietrak123@gmail.com", "AQAAAAIAAYagAAAAEFXXiG9JsOa+FENSnMKaeJsgyjNY5TCet+102sG+p88vr3paf35Urf7g8CzFivnwlA==", "SWETRAK" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("005c89ea-4249-4b11-a614-0ef68fdc8969"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("03aeb449-7fbd-4a07-81b4-fc7434c3f50a"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("1b16d714-1878-47df-8b7e-a6b1e9803fdd"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("1cba8b00-58fd-42f1-bf94-237cbb8ba508"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("1cd7c9f4-499f-4718-90b5-d21da8a326f2"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("20c0532b-c30f-4067-9147-23efda3ddb26"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("46f6464c-826d-4dd7-bf27-ea7fec9fa50e"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("4a0144ef-00ce-45e1-980b-637c6c6d00ef"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("5d11b477-7fa2-432d-9a29-9937fecb5412"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("6623c99b-003d-4fbb-9812-0d0686efbf10"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("7aa0100e-d9fd-45a9-b7b9-cbabf49c6e69"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("7bd09eee-7cf5-441c-8cad-6cca43c06f40"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("81450962-8e6e-4f0b-9dd9-0206e1ea1d30"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("82efc76e-5fb8-49b6-8b7a-89a35c1d2f7e"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("894e8410-f5ee-458a-bfb2-c0c898377d7a"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("8bcb6155-3412-4ee6-9562-1f5d2b8cdec1"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("a7003e43-6dfd-42bb-b2ff-c0d20d32db93"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("b1908bc6-dd7a-48b9-8426-48d3c5de350f"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("b8300a76-4e84-4f19-a0d9-426930fafff4"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("bf65a9bc-c149-412d-a8b9-a0eb25267b99"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("d5936d12-69b4-4a43-b83d-904273687828"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("ddfc9adf-cefd-4479-99c3-5e2f73087360"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("e32f1964-f233-4103-abf9-e9fc40c907ca"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("f240460a-70ca-4c51-94be-288b00443ccc"));

            migrationBuilder.DeleteData(
                table: "question",
                keyColumn: "Id",
                keyValue: new Guid("fc5f08a9-0228-4fd7-b9bb-c3bd08b85901"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("bf04cada-2d88-404c-a66a-3614f9edbc16"));

            migrationBuilder.DropColumn(
                name: "Win",
                table: "daily_bingo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "daily_bingo",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 6, 21, 54, 41, 644, DateTimeKind.Local).AddTicks(1940),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Local));

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
    }
}
