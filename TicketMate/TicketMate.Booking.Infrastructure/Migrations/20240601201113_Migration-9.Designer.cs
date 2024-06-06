﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketMate.Booking.Infrastructure;

#nullable disable

namespace TicketMate.Booking.Infrastructure.Migrations
{
    [DbContext(typeof(BookingDbContext))]
    [Migration("20240601201113_Migration-9")]
    partial class Migration9
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketMate.Booking.Api.Models.TravelSearch", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("EndLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TravelDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TravelSearch");
                });

            modelBuilder.Entity("TicketMate.Booking.Application.Dtos.SelectedBusStands", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BusStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScheduledBusScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("StandArrivalTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ScheduledBusScheduleId");

                    b.ToTable("SelectedBusStands");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.BusRouteStands", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusRouteRoutId")
                        .HasColumnType("int");

                    b.Property<string>("StandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BusRouteStands");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.RegisteredBuses", b =>
                {
                    b.Property<int>("BusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusId"));

                    b.Property<bool>("ACorNONAC")
                        .HasColumnType("bit");

                    b.Property<int>("SetsCount")
                        .HasColumnType("int");

                    b.HasKey("BusId");

                    b.ToTable("RegisteredBuses");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.RegisteredCarriages", b =>
                {
                    b.Property<int>("CarriageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarriageId"));

                    b.Property<int>("CarriageClass")
                        .HasColumnType("int");

                    b.Property<string>("CarriageNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatsCount")
                        .HasColumnType("int");

                    b.HasKey("CarriageId");

                    b.ToTable("RegisteredCarriages");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.ScheduledBusDates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArrivalDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScheduledBusScheduleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScheduledBusScheduleId");

                    b.ToTable("ScheduledBusDates");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.ScheduledBuses", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleId"));

                    b.Property<string>("ArrivalTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comfortability")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegisteredBusBusId")
                        .HasColumnType("int");

                    b.Property<string>("RoutNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ScheduleId");

                    b.HasIndex("RegisteredBusBusId");

                    b.ToTable("ScheduledBuses");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.ScheduledCarriages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClassType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegisteredCarriageCarriageId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduledTrainSchedulId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegisteredCarriageCarriageId");

                    b.HasIndex("ScheduledTrainSchedulId");

                    b.ToTable("ScheduledCarriages");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.ScheduledTrainDates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArrivalDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScheduledTrainSchedulId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScheduledTrainSchedulId");

                    b.ToTable("ScheduledTrainDates");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.ScheduledTrains", b =>
                {
                    b.Property<int>("SchedulId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchedulId"));

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FirstClassTicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SecondClassTicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("StartStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainArrivalTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainDepartureTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainRoutNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchedulId");

                    b.ToTable("ScheduledTrains");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.SelCarriageSeatStructures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Avalability")
                        .HasColumnType("bit");

                    b.Property<int>("RegisteredCarriageCarriageId")
                        .HasColumnType("int");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegisteredCarriageCarriageId");

                    b.ToTable("SelCarriageSeatStructures");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.SelectedSeatStructures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RegisteredBusBusId")
                        .HasColumnType("int");

                    b.Property<bool>("SeatAvailability")
                        .HasColumnType("bit");

                    b.Property<string>("SeatId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegisteredBusBusId");

                    b.ToTable("SelectedSeatStructures");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.SelectedTrainStations", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("ScheduledTrainSchedulId")
                        .HasColumnType("int");

                    b.Property<string>("TrainDepartureTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainStationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainarrivalTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("ScheduledTrainSchedulId");

                    b.ToTable("SelectedTrainStations");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.TrainRaliwayStations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TrainRailwayId")
                        .HasColumnType("int");

                    b.Property<string>("TrainStationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainRaliwayStations");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Models.BusBooking", b =>
                {
                    b.Property<int>("BusBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusBookingId"));

                    b.Property<string>("BoardingPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingSeatCount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingSeatNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<int>("BusScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("DroppingPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassengerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("RouteNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BusBookingId");

                    b.ToTable("BusBookings");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Models.BusBookingCancelled", b =>
                {
                    b.Property<int>("CancelledBusBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CancelledBusBookingId"));

                    b.Property<string>("BoardingPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingSeatCount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingSeatNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<int>("BusScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("CancellationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DroppingPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OriginalBusBookingId")
                        .HasColumnType("int");

                    b.Property<string>("PassengerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("RouteNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CancelledBusBookingId");

                    b.ToTable("BusBookingCancels");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Models.TrainBooking", b =>
                {
                    b.Property<int>("TrainBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainBookingId"));

                    b.Property<string>("BoardingPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookingCarriageNo")
                        .HasColumnType("int");

                    b.Property<string>("BookingClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingSeatCount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingSeatNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DroppingPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassengerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("RouteNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrainScheduleId")
                        .HasColumnType("int");

                    b.HasKey("TrainBookingId");

                    b.ToTable("TrainBookings");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Models.TrainBookingCancelled", b =>
                {
                    b.Property<int>("CancelledTrainBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CancelledTrainBookingId"));

                    b.Property<string>("BoardingPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookingCarriageNo")
                        .HasColumnType("int");

                    b.Property<string>("BookingClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingSeatCount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingSeatNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CancellationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DroppingPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OriginalTrainBookingId")
                        .HasColumnType("int");

                    b.Property<string>("PassengerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("RouteNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrainScheduleId")
                        .HasColumnType("int");

                    b.HasKey("CancelledTrainBookingId");

                    b.ToTable("TrainBookingCancels");
                });

            modelBuilder.Entity("TicketMate.Booking.Application.Dtos.SelectedBusStands", b =>
                {
                    b.HasOne("TicketMate.Booking.Domain.Dtos.ScheduledBuses", "ScheduledBus")
                        .WithMany("SelectedBusStands")
                        .HasForeignKey("ScheduledBusScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ScheduledBus");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.ScheduledBusDates", b =>
                {
                    b.HasOne("TicketMate.Booking.Domain.Dtos.ScheduledBuses", "ScheduledBus")
                        .WithMany("ScheduledBusDatesList")
                        .HasForeignKey("ScheduledBusScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ScheduledBus");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.ScheduledBuses", b =>
                {
                    b.HasOne("TicketMate.Booking.Domain.Dtos.RegisteredBuses", "RegisteredBus")
                        .WithMany("ScheduledBuses")
                        .HasForeignKey("RegisteredBusBusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegisteredBus");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.ScheduledCarriages", b =>
                {
                    b.HasOne("TicketMate.Booking.Domain.Dtos.RegisteredCarriages", "RegisteredCarriage")
                        .WithMany("ScheduledCarriages")
                        .HasForeignKey("RegisteredCarriageCarriageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketMate.Booking.Domain.Dtos.ScheduledTrains", "ScheduledTrain")
                        .WithMany("ScheduledCarriages")
                        .HasForeignKey("ScheduledTrainSchedulId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegisteredCarriage");

                    b.Navigation("ScheduledTrain");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.ScheduledTrainDates", b =>
                {
                    b.HasOne("TicketMate.Booking.Domain.Dtos.ScheduledTrains", "ScheduledTrain")
                        .WithMany("ScheduledTrainDates")
                        .HasForeignKey("ScheduledTrainSchedulId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ScheduledTrain");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.SelCarriageSeatStructures", b =>
                {
                    b.HasOne("TicketMate.Booking.Domain.Dtos.RegisteredCarriages", "RegisteredCarriage")
                        .WithMany("SelCarriageSeatStructures")
                        .HasForeignKey("RegisteredCarriageCarriageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegisteredCarriage");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.SelectedSeatStructures", b =>
                {
                    b.HasOne("TicketMate.Booking.Domain.Dtos.RegisteredBuses", "RegisteredBus")
                        .WithMany("SelectedSeatStructures")
                        .HasForeignKey("RegisteredBusBusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegisteredBus");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.SelectedTrainStations", b =>
                {
                    b.HasOne("TicketMate.Booking.Domain.Dtos.ScheduledTrains", "ScheduledTrain")
                        .WithMany("SelectedTrainStations")
                        .HasForeignKey("ScheduledTrainSchedulId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ScheduledTrain");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.RegisteredBuses", b =>
                {
                    b.Navigation("ScheduledBuses");

                    b.Navigation("SelectedSeatStructures");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.RegisteredCarriages", b =>
                {
                    b.Navigation("ScheduledCarriages");

                    b.Navigation("SelCarriageSeatStructures");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.ScheduledBuses", b =>
                {
                    b.Navigation("ScheduledBusDatesList");

                    b.Navigation("SelectedBusStands");
                });

            modelBuilder.Entity("TicketMate.Booking.Domain.Dtos.ScheduledTrains", b =>
                {
                    b.Navigation("ScheduledCarriages");

                    b.Navigation("ScheduledTrainDates");

                    b.Navigation("SelectedTrainStations");
                });
#pragma warning restore 612, 618
        }
    }
}
