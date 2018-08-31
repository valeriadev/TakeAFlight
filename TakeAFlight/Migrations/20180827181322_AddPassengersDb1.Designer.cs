﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TakeAFlight.Models;

namespace TakeAFlight.Migrations
{
    [DbContext(typeof(TakeAFlightContext))]
    [Migration("20180827181322_AddPassengersDb1")]
    partial class AddPassengersDb1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TakeAFlight.Models.Destination", b =>
                {
                    b.Property<int>("DestinationID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.HasKey("DestinationID");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("TakeAFlight.Models.Flight", b =>
                {
                    b.Property<int>("FlightID")
                        .ValueGeneratedOnAdd();

                    b.Property<TimeSpan>("Departure");

                    b.Property<int>("DestinationID");

                    b.Property<TimeSpan?>("Duration");

                    b.Property<double>("Price");

                    b.HasKey("FlightID");

                    b.HasIndex("DestinationID");

                    b.ToTable("Flight");
                });

            modelBuilder.Entity("TakeAFlight.Models.Passenger", b =>
                {
                    b.Property<int>("PassengerID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("Nationality");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("PassengerID");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("TakeAFlight.Models.Flight", b =>
                {
                    b.HasOne("TakeAFlight.Models.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}