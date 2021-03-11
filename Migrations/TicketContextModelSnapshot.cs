﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketApp.Context;

namespace TicketApp.Migrations
{
    [DbContext(typeof(TicketContext))]
    partial class TicketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketApp.Entities.Ticket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartingLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TravelDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Work Travel(conference in istanbul)",
                            DestinationLocation = "Istanbul",
                            ExpDate = new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Work",
                            StartingLocation = "Queen Alia",
                            TravelDate = new DateTime(2020, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            ID = 2,
                            Description = "Recreation Travel",
                            DestinationLocation = "Ankara",
                            ExpDate = new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Recreation",
                            StartingLocation = "Queen Alia",
                            TravelDate = new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            ID = 3,
                            Description = "Work Travel",
                            DestinationLocation = "Cairo",
                            ExpDate = new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "work",
                            StartingLocation = "Queen Alia",
                            TravelDate = new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            ID = 4,
                            Description = "Discover Travel",
                            DestinationLocation = "Moroco",
                            ExpDate = new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "History",
                            StartingLocation = "Queen Alia",
                            TravelDate = new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        });
                });

            modelBuilder.Entity("TicketApp.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EmailAddress")
                        .IsUnique()
                        .HasFilter("[EmailAddress] IS NOT NULL");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DateOfBirth = new DateTime(1997, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "admin@admin.com",
                            Gender = "Female",
                            Password = "admin12A*",
                            UserName = "shoruq",
                            UserTypeId = 1
                        },
                        new
                        {
                            ID = 2,
                            DateOfBirth = new DateTime(1998, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "anas@ticket.com",
                            Gender = "male",
                            Password = "anas12A*",
                            UserName = "anas",
                            UserTypeId = 2
                        },
                        new
                        {
                            ID = 3,
                            DateOfBirth = new DateTime(1996, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "ahmad@ticket.com",
                            Gender = "male",
                            Password = "ahmad12A*",
                            UserName = "ahmad",
                            UserTypeId = 2
                        });
                });

            modelBuilder.Entity("TicketApp.Entities.UserType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Type = "Admin"
                        },
                        new
                        {
                            ID = 2,
                            Type = "Client"
                        });
                });

            modelBuilder.Entity("TicketApp.Entities.Ticket", b =>
                {
                    b.HasOne("TicketApp.Entities.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TicketApp.Entities.User", b =>
                {
                    b.HasOne("TicketApp.Entities.UserType", "UserType")
                        .WithMany()
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("TicketApp.Entities.User", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
