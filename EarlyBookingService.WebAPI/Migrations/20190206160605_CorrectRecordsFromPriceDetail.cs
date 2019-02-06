using Microsoft.EntityFrameworkCore.Migrations;

namespace EarlyBookingService.WebAPI.Migrations
{
    public partial class CorrectRecordsFromPriceDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PriceDetail",
                keyColumn: "Id",
                keyValue: 13,
                column: "PurchaseCostId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "PriceDetail",
                keyColumn: "Id",
                keyValue: 15,
                column: "PurchaseCostId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "PriceDetail",
                keyColumn: "Id",
                keyValue: 17,
                column: "PurchaseCostId",
                value: 8);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PriceDetail",
                keyColumn: "Id",
                keyValue: 13,
                column: "PurchaseCostId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "PriceDetail",
                keyColumn: "Id",
                keyValue: 15,
                column: "PurchaseCostId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "PriceDetail",
                keyColumn: "Id",
                keyValue: 17,
                column: "PurchaseCostId",
                value: 7);
        }
    }
}
