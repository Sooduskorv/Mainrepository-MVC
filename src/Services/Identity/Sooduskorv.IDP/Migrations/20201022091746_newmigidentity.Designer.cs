﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sooduskorv.IDP.Data;

namespace Sooduskorv.IDP.Migrations
{
    [DbContext(typeof(IdentityApplicationDbContext))]
    [Migration("20201022091746_newmigidentity")]
    partial class newmigidentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Identity.Data.Entities.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1c80b31-2b9a-47a3-b326-06c5b28175c5"),
                            ConcurrencyStamp = "ed554760-c325-4863-9095-077c501888f9",
                            Type = "given_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Hanna"
                        },
                        new
                        {
                            Id = new Guid("179069d4-10a3-4ec2-9d57-67f20eecd9b9"),
                            ConcurrencyStamp = "e4a22069-9643-4daf-8572-69f86e0f7be5",
                            Type = "family_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Forest"
                        },
                        new
                        {
                            Id = new Guid("c079d835-37a6-4cb1-95de-95b007fa0b29"),
                            ConcurrencyStamp = "e9920b4d-646d-43c8-9e61-e4ef8c033524",
                            Type = "email",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "hanna@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("0d2a5459-e20b-4513-8b39-5b97c128f3d0"),
                            ConcurrencyStamp = "6b78025d-5cdf-4dcd-ac8a-035a959bf57e",
                            Type = "address",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Tammsaare tee"
                        },
                        new
                        {
                            Id = new Guid("f7067b87-3cf3-4b90-9ad5-74f77c189f92"),
                            ConcurrencyStamp = "e7505307-733e-459a-97cd-415728cc6157",
                            Type = "country",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "somevalue"
                        },
                        new
                        {
                            Id = new Guid("dab32c86-d2ee-4562-b38c-6087df5dc340"),
                            ConcurrencyStamp = "0787dddf-06dc-41b2-a2a5-1bc5c1cf691f",
                            Type = "given_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Bob"
                        },
                        new
                        {
                            Id = new Guid("c4ff4973-a7b0-4edd-92b2-d9cb34761f77"),
                            ConcurrencyStamp = "b67f7dfc-0ecb-49ba-bcd8-adfb34c87f20",
                            Type = "family_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Oak"
                        },
                        new
                        {
                            Id = new Guid("daebc6f7-9a65-4682-8c07-165d42d8c75f"),
                            ConcurrencyStamp = "11be5de9-934a-4f43-88ba-3c33b7f483a7",
                            Type = "email",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "bob@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("7e715486-4af2-4c3e-bf72-bb107afc8e78"),
                            ConcurrencyStamp = "1f928e7b-eb87-4e77-8d67-8956ed6d9f1f",
                            Type = "address",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Ehitajate Tee"
                        },
                        new
                        {
                            Id = new Guid("b1209055-b7bf-4762-8957-aea91c815119"),
                            ConcurrencyStamp = "da1b48b3-7051-463d-a911-2d293a7f6626",
                            Type = "country",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "somevalue"
                        });
                });

            modelBuilder.Entity("Identity.Data.Entities.UserData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SecurityCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("SecurityCodeExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Subject")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Active = true,
                            ConcurrencyStamp = "12496d54-2af7-4baf-aedd-74357d600081",
                            Password = "password",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "d860efca-22d9-47fd-8249-791ba61b07c7",
                            Username = "Hanna"
                        },
                        new
                        {
                            Id = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Active = true,
                            ConcurrencyStamp = "6cecafbc-7b6d-4cfb-a1d5-f15d5f711be9",
                            Password = "password",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                            Username = "Bob"
                        });
                });

            modelBuilder.Entity("Identity.Data.Entities.UserClaim", b =>
                {
                    b.HasOne("Identity.Data.Entities.UserData", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}