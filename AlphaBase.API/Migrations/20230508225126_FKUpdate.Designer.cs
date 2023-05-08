﻿// <auto-generated />
using System;
using Alpha.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Alpha.API.Migrations
{
    [DbContext(typeof(AlphaBaseContext))]
    [Migration("20230508225126_FKUpdate")]
    partial class FKUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Alpha.API.Data.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AddressId"));

                    b.Property<string>("Address1")
                        .HasColumnType("text");

                    b.Property<string>("Address2")
                        .HasColumnType("text");

                    b.Property<string>("Address3")
                        .HasColumnType("text");

                    b.Property<string>("CityTown")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .HasColumnType("text");

                    b.Property<string>("StateProvince")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("AddressId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            Address1 = "1461 Upper Second Creek Road",
                            Address2 = "",
                            Address3 = "",
                            CityTown = "Hazard",
                            Country = "USA",
                            PostalCode = "41701",
                            StateProvince = "KY",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Alpha.API.Data.Entities.EmailAddress", b =>
                {
                    b.Property<int>("EmailAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmailAddressId"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("EmailAddressId");

                    b.HasIndex("UserId");

                    b.ToTable("EmailAddresses");

                    b.HasData(
                        new
                        {
                            EmailAddressId = 1,
                            Email = "michaelshep52@gmail.com",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Alpha.API.Data.Entities.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PaymentId"));

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            PaymentId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Alpha.API.Data.Entities.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PhoneId"));

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("PhoneId");

                    b.HasIndex("UserId");

                    b.ToTable("Phone");

                    b.HasData(
                        new
                        {
                            PhoneId = 1,
                            PhoneNumber = -4317,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Alpha.API.Data.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FirstName = "Michael",
                            LastName = "Shepherd",
                            Password = "Password1234321!"
                        });
                });

            modelBuilder.Entity("Alpha.API.Data.Entities.Address", b =>
                {
                    b.HasOne("Alpha.API.Data.Entities.User", "User")
                        .WithOne("Address")
                        .HasForeignKey("Alpha.API.Data.Entities.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Alpha.API.Data.Entities.EmailAddress", b =>
                {
                    b.HasOne("Alpha.API.Data.Entities.User", "User")
                        .WithMany("EmailAddress")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Alpha.API.Data.Entities.Payment", b =>
                {
                    b.HasOne("Alpha.API.Data.Entities.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Alpha.API.Data.Entities.Phone", b =>
                {
                    b.HasOne("Alpha.API.Data.Entities.User", "User")
                        .WithMany("Phones")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Alpha.API.Data.Entities.User", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("EmailAddress");

                    b.Navigation("Payments");

                    b.Navigation("Phones");
                });
#pragma warning restore 612, 618
        }
    }
}
