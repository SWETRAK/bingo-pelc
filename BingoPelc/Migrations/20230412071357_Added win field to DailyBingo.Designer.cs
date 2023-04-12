﻿// <auto-generated />
using System;
using BingoPelc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BingoPelc.Migrations
{
    [DbContext(typeof(DomainContextDb))]
    [Migration("20230412071357_Added win field to DailyBingo")]
    partial class AddedwinfieldtoDailyBingo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BingoPelc.Entities.DailyBingo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Local));

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Win")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("daily_bingo", (string)null);
                });

            modelBuilder.Entity("BingoPelc.Entities.DailyQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Checked")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<Guid>("DailyBingoId")
                        .HasColumnType("uuid");

                    b.Property<int>("Index")
                        .HasColumnType("integer");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DailyBingoId");

                    b.HasIndex("QuestionId");

                    b.ToTable("daily_questions", (string)null);
                });

            modelBuilder.Entity("BingoPelc.Entities.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("question", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1cba8b00-58fd-42f1-bf94-237cbb8ba508"),
                            Title = "To co może po piwerku"
                        },
                        new
                        {
                            Id = new Guid("f240460a-70ca-4c51-94be-288b00443ccc"),
                            Title = "No kurde stary, zanim ja pojade do domu i wróce to 3 godziny mijają"
                        },
                        new
                        {
                            Id = new Guid("46f6464c-826d-4dd7-bf27-ea7fec9fa50e"),
                            Title = "Mam spotkanie samorządu"
                        },
                        new
                        {
                            Id = new Guid("b8300a76-4e84-4f19-a0d9-426930fafff4"),
                            Title = "Dojeżdżam na polibudę zaraz"
                        },
                        new
                        {
                            Id = new Guid("6623c99b-003d-4fbb-9812-0d0686efbf10"),
                            Title = "Nie stać mnie"
                        },
                        new
                        {
                            Id = new Guid("ddfc9adf-cefd-4479-99c3-5e2f73087360"),
                            Title = "Przepraszam za spóźnienie"
                        },
                        new
                        {
                            Id = new Guid("20c0532b-c30f-4067-9147-23efda3ddb26"),
                            Title = "Sprawdzam wnioski stypendialne"
                        },
                        new
                        {
                            Id = new Guid("4a0144ef-00ce-45e1-980b-637c6c6d00ef"),
                            Title = "Kiedyś ci oddam bo nie mam teraz"
                        },
                        new
                        {
                            Id = new Guid("82efc76e-5fb8-49b6-8b7a-89a35c1d2f7e"),
                            Title = "Rada wydziału"
                        },
                        new
                        {
                            Id = new Guid("1cd7c9f4-499f-4718-90b5-d21da8a326f2"),
                            Title = "Nie chciało mi się "
                        },
                        new
                        {
                            Id = new Guid("bf65a9bc-c149-412d-a8b9-a0eb25267b99"),
                            Title = "Jak mi zapłacicie za bolta, to mogę opić"
                        },
                        new
                        {
                            Id = new Guid("8bcb6155-3412-4ee6-9562-1f5d2b8cdec1"),
                            Title = "Urodziny"
                        },
                        new
                        {
                            Id = new Guid("894e8410-f5ee-458a-bfb2-c0c898377d7a"),
                            Title = "Zachlałem"
                        },
                        new
                        {
                            Id = new Guid("b1908bc6-dd7a-48b9-8426-48d3c5de350f"),
                            Title = "Korki były"
                        },
                        new
                        {
                            Id = new Guid("1b16d714-1878-47df-8b7e-a6b1e9803fdd"),
                            Title = "Więcej czasu na tej jebanej uczelni spędzam niż w domu"
                        },
                        new
                        {
                            Id = new Guid("d5936d12-69b4-4a43-b83d-904273687828"),
                            Title = "Chodźmy do Kazika"
                        },
                        new
                        {
                            Id = new Guid("005c89ea-4249-4b11-a614-0ef68fdc8969"),
                            Title = "Autobus nie przyjechał"
                        },
                        new
                        {
                            Id = new Guid("5d11b477-7fa2-432d-9a29-9937fecb5412"),
                            Title = "Wyjechać z tej mojej wsi"
                        },
                        new
                        {
                            Id = new Guid("03aeb449-7fbd-4a07-81b4-fc7434c3f50a"),
                            Title = "Alkochol w plecaku/torbie"
                        },
                        new
                        {
                            Id = new Guid("7aa0100e-d9fd-45a9-b7b9-cbabf49c6e69"),
                            Title = "EHE HE HE"
                        },
                        new
                        {
                            Id = new Guid("fc5f08a9-0228-4fd7-b9bb-c3bd08b85901"),
                            Title = "Rowerem przyjechałem"
                        },
                        new
                        {
                            Id = new Guid("7bd09eee-7cf5-441c-8cad-6cca43c06f40"),
                            Title = "Czego tak?"
                        },
                        new
                        {
                            Id = new Guid("a7003e43-6dfd-42bb-b2ff-c0d20d32db93"),
                            Title = "Kupiłem monstera za x ziko, ale mi się zwróci"
                        },
                        new
                        {
                            Id = new Guid("81450962-8e6e-4f0b-9dd9-0206e1ea1d30"),
                            Title = "Ja odpuszczam wykłady, idę do Kazika"
                        },
                        new
                        {
                            Id = new Guid("e32f1964-f233-4103-abf9-e9fc40c907ca"),
                            Title = "Ja przyniosę zwolniennie na następne zajęcia"
                        });
                });

            modelBuilder.Entity("BingoPelc.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bf04cada-2d88-404c-a66a-3614f9edbc16"),
                            Email = "kamilpietrak123@gmail.com",
                            HashedPassword = "AQAAAAIAAYagAAAAEFXXiG9JsOa+FENSnMKaeJsgyjNY5TCet+102sG+p88vr3paf35Urf7g8CzFivnwlA==",
                            Nickname = "SWETRAK"
                        });
                });

            modelBuilder.Entity("BingoPelc.Entities.DailyBingo", b =>
                {
                    b.HasOne("BingoPelc.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BingoPelc.Entities.DailyQuestion", b =>
                {
                    b.HasOne("BingoPelc.Entities.DailyBingo", "DailyBingo")
                        .WithMany("DailyQuestions")
                        .HasForeignKey("DailyBingoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BingoPelc.Entities.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DailyBingo");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("BingoPelc.Entities.DailyBingo", b =>
                {
                    b.Navigation("DailyQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
