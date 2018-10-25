﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TakeAFlight.Models;

namespace TakeAFlight.Migrations
{
    [DbContext(typeof(TakeAFlightContext))]
    partial class TakeAFlightContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TakeAFlight.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("TakeAFlight.Models.Destination", b =>
                {
                    b.Property<int>("DestinationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.HasKey("DestinationID");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("TakeAFlight.Models.Flight", b =>
                {
                    b.Property<int>("FlightID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Departure");

                    b.Property<int>("DestinationID");

                    b.Property<TimeSpan?>("Duration");

                    b.Property<double>("Price");

                    b.HasKey("FlightID");

                    b.HasIndex("DestinationID");

                    b.ToTable("Flight");
                });

            modelBuilder.Entity("TakeAFlight.Models.FlightOrder", b =>
                {
                    b.Property<int>("FlightOrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FlightID");

                    b.Property<int>("PassengerID");

                    b.Property<string>("TicketNumber");

                    b.HasKey("FlightOrderID");

                    b.HasIndex("FlightID");

                    b.HasIndex("PassengerID");

                    b.ToTable("FlightOrders");
                });

            modelBuilder.Entity("TakeAFlight.Models.Passenger", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserID");

                    b.Property<DateTime?>("DateOfBirth")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<int>("IdPassenger");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("Nationality");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserID");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("TakeAFlight.Models.Flight", b =>
                {
                    b.HasOne("TakeAFlight.Models.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TakeAFlight.Models.FlightOrder", b =>
                {
                    b.HasOne("TakeAFlight.Models.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TakeAFlight.Models.Passenger", "Passenger")
                        .WithMany()
                        .HasForeignKey("PassengerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TakeAFlight.Models.Passenger", b =>
                {
                    b.HasOne("TakeAFlight.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("ApplicationUserID");
                });
#pragma warning restore 612, 618
        }
    }
}
