﻿// <auto-generated />
using System;
using Catalog.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Catalog.API.Migrations
{
    [DbContext(typeof(CatalogApplicationDbContext))]
    [Migration("20201111232730_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Catalog.Data.Categories.CategoryData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Catalog.Data.Parties.PartyData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AddressId")
                        .HasColumnType("text");

                    b.Property<string>("Hours")
                        .HasColumnType("text");

                    b.Property<string>("Latitude")
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Organization")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("Catalog.Data.Prices.PriceData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(16,2)");

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("Catalog.Data.ProductOfParty.ProductsOfPartyData", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<string>("PartyId")
                        .HasColumnType("text");

                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("PriceId")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ProductId", "PartyId");

                    b.ToTable("ProductsOfParties");
                });

            modelBuilder.Entity("Catalog.Data.Products.ProductData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Amount")
                        .HasColumnType("text");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("CategoryId")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Composition")
                        .HasColumnType("text");

                    b.Property<string>("CountryOfOrigin")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Measure")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("SubCategoryId")
                        .HasColumnType("text");

                    b.Property<string>("Supplier")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Catalog.Data.SubCategories.SubCategoryData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("CategoryId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Catalog.Data.UserProfiles.UserProfileData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("SelectedParty")
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SubscriptionLevel")
                        .IsRequired()
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}