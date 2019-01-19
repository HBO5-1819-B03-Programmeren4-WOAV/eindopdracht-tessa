using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EarlyBookingService.WebAPI.Migrations
{
    public partial class UpdateSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookingDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
