using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EarlyBookingService.WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accomodation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accomodation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReservationNumber = table.Column<string>(nullable: true),
                    BookingDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    AccomodationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Accomodation_AccomodationId",
                        column: x => x.AccomodationId,
                        principalTable: "Accomodation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcommodationId = table.Column<int>(nullable: false),
                    AccomodationId = table.Column<int>(nullable: true),
                    CostType = table.Column<int>(nullable: false),
                    BookingStartDate = table.Column<DateTime>(nullable: false),
                    BookingEndDate = table.Column<DateTime>(nullable: false),
                    ReservationStartDate = table.Column<DateTime>(nullable: false),
                    ReservationEndDate = table.Column<DateTime>(nullable: false),
                    ValueType = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    PrepaymentDate = table.Column<DateTime>(nullable: false),
                    PrepaymentPercentage = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseCost_Accomodation_AccomodationId",
                        column: x => x.AccomodationId,
                        principalTable: "Accomodation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BookingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participant_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PriceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookingId = table.Column<int>(nullable: false),
                    PurchaseCostId = table.Column<int>(nullable: false),
                    Cost = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceDetails_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceDetails_PurchaseCost_PurchaseCostId",
                        column: x => x.PurchaseCostId,
                        principalTable: "PurchaseCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accomodation",
                columns: new[] { "Id", "Country", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "Belgium", "tessa.braeke@gmail.com", "Hotel 't Zonnetje" },
                    { 2, "Netherlands", "tessa.braeke@gmail.com", "Hotel aan Zee" },
                    { 3, "United Kingdom", "tessa.braeke@gmail.com", "Joly Sailor" },
                    { 4, "Germany", "tessa.braeke@gmail.com", "Hotel am See" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseCost",
                columns: new[] { "Id", "AccomodationId", "AcommodationId", "Amount", "BookingEndDate", "BookingStartDate", "CostType", "PrepaymentDate", "PrepaymentPercentage", "ReservationEndDate", "ReservationStartDate", "Status", "ValueType" },
                values: new object[,]
                {
                    { 1, null, 1, 10.0, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 },
                    { 2, null, 1, 50.0, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2019, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 3, null, 2, 15.0, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 },
                    { 4, null, 2, 70.0, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2019, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 5, null, 3, 20.0, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 },
                    { 6, null, 3, 100.0, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2019, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 7, null, 4, 25.0, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 },
                    { 8, null, 4, 150.0, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2019, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "AccomodationId", "BookingDate", "EndDate", "ReservationNumber", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1A1A1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A2A2A2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B1B1B1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B2B2B2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C1C1C1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C2C2C2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C3C3C3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D1D1D1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D2D2D2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D3D3D3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Participant",
                columns: new[] { "Id", "BirthDate", "BookingId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jan", "Kapitein" },
                    { 22, new DateTime(1985, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Lisa", "Simpson" },
                    { 21, new DateTime(1953, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Marge", "Simpson" },
                    { 20, new DateTime(1950, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Homer", "Simpson" },
                    { 19, new DateTime(1984, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Nathalie", "Sanders" },
                    { 18, new DateTime(1982, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Annelies", "Sanders" },
                    { 17, new DateTime(1990, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Thomas", "Sanders" },
                    { 16, new DateTime(1970, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Ali", "Baba" },
                    { 15, new DateTime(1970, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Fatima", "Baba" },
                    { 14, new DateTime(1999, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Jeroen", "Vos" },
                    { 13, new DateTime(2000, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Jaap", "Vos" },
                    { 12, new DateTime(1941, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Daenerys", "Targaryen" },
                    { 11, new DateTime(1940, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Jon", "Snow" },
                    { 10, new DateTime(1990, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Babbel", "Eekhoorn" },
                    { 9, new DateTime(1990, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Knabbel", "Eekhoorn" },
                    { 8, new DateTime(1955, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Daniel", "Braeke" },
                    { 7, new DateTime(1961, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Lorna", "Bogaert" },
                    { 6, new DateTime(1918, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Georges", "Van Renterghem" },
                    { 5, new DateTime(1918, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Irma", "De Bruyne" },
                    { 4, new DateTime(1960, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Korneel", "Kapitein" },
                    { 3, new DateTime(1995, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Joris", "Kapitein" },
                    { 2, new DateTime(1992, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Piet", "Kapitein" },
                    { 23, new DateTime(1984, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Bart", "Simpson" },
                    { 24, new DateTime(1989, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Maggie", "Simpson" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_AccomodationId",
                table: "Booking",
                column: "AccomodationId");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_BookingId",
                table: "Participant",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceDetails_BookingId",
                table: "PriceDetails",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceDetails_PurchaseCostId",
                table: "PriceDetails",
                column: "PurchaseCostId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseCost_AccomodationId",
                table: "PurchaseCost",
                column: "AccomodationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participant");

            migrationBuilder.DropTable(
                name: "PriceDetails");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "PurchaseCost");

            migrationBuilder.DropTable(
                name: "Accomodation");
        }
    }
}
