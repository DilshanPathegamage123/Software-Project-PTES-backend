﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketMate.Vehicle.Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "ScheduledTrainDates",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "ScheduledTrainDates");
        }
    }
}
