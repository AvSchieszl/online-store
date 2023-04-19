using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineStore.DataAccess.Migrations
{
    public partial class UpdateSeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7278), 87.5254373699426m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7315), 100.429537762167m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7334), 77.7217467525544m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7353), 225.632422530214m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7371), 24.4870746661245m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7387), 198.127267977673m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7405), 121.171389093071m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7420), 34.9944961040437m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7437), 164.270820038826m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7505), 149.697546349084m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7524), 246.530993850733m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7540), 233.321905733879m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7557), 229.296046484197m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7573), 82.7862907811379m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7591), 213.575243058908m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7606), 183.725237995058m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7623), 162.409059816947m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7640), 105.767841483576m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7657), 215.396449065045m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7673), 236.413188058466m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7690), 127.738693977874m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7818), 205.299944024241m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7836), 231.083213191756m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7852), 226.960200370424m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7869), 167.045202672139m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7298), 58.2472867116046m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7319), 246.057172190162m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7337), 52.7678934837065m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7356), 249.533610984584m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7374), 115.437665130146m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7390), 20.7698607078101m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7408), 210.257848744769m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7423), 239.700128078961m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7440), 209.146406573401m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7509), 189.342430553674m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7528), 71.8196176287591m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7543), 82.3045178586494m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7561), 118.516504721406m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7577), 78.2034496625488m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7594), 220.947093306566m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7609), 42.9806252718398m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7626), 54.3548503681764m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7643), 33.5270223244457m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7660), 212.400427007645m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7676), 204.515661066212m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7693), 90.614922492101m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7822), 247.992621653791m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7840), 178.746363119342m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7855), 39.981689338744m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(7872), 112.179191796511m });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantity",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quantity",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 4,
                column: "Quantity",
                value: 79);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quantity",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quantity",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 8,
                column: "Quantity",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 9,
                column: "Quantity",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 11,
                column: "Quantity",
                value: 93);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 12,
                column: "Quantity",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 13,
                column: "Quantity",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 14,
                column: "Quantity",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 15,
                column: "Quantity",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 16,
                column: "Quantity",
                value: 97);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 17,
                column: "Quantity",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 18,
                column: "Quantity",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 19,
                column: "Quantity",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 20,
                column: "Quantity",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 21,
                column: "Quantity",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 22,
                column: "Quantity",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 23,
                column: "Quantity",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 24,
                column: "Quantity",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 25,
                column: "Quantity",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 26,
                column: "Quantity",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 27,
                column: "Quantity",
                value: 82);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 28,
                column: "Quantity",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 29,
                column: "Quantity",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 30,
                column: "Quantity",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 31,
                column: "Quantity",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 32,
                column: "Quantity",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 33,
                column: "Quantity",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 34,
                column: "Quantity",
                value: 74);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 35,
                column: "Quantity",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 36,
                column: "Quantity",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 37,
                column: "Quantity",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 38,
                column: "Quantity",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 39,
                column: "Quantity",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 40,
                column: "Quantity",
                value: 73);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 41,
                column: "Quantity",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 42,
                column: "Quantity",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 43,
                column: "Quantity",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 44,
                column: "Quantity",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 45,
                column: "Quantity",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 46,
                column: "Quantity",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 47,
                column: "Quantity",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 48,
                column: "Quantity",
                value: 87);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 49,
                column: "Quantity",
                value: 87);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 50,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "StockEvent",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "StockEvent",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 19, 11, 7, 53, 595, DateTimeKind.Local).AddTicks(8727));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4588), 120.496608206211m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4620), 198.707481416315m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4640), 186.523241260077m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4658), 223.482710898234m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4718), 240.808328275891m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4736), 219.013527536795m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4753), 239.768308159059m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4769), 48.8739030055522m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4786), 135.460981348568m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4803), 53.4450919943265m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4821), 225.309408898444m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4837), 113.19250617742m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4855), 72.1077022986276m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4871), 48.4412802708525m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4889), 141.979780053052m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4904), 199.966421612541m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4951), 44.253821579191m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4969), 157.08414208178m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4987), 119.313735125395m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5002), 135.8579890256m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5020), 101.303068064171m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5035), 30.7123129986259m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5053), 192.679961975623m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5069), 21.4967873603568m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5086), 177.84221629191m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4601), 180.314387417907m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4623), 245.245236145053m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4643), 33.1545869158288m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4661), 32.79672785384m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4721), 151.509911691045m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4739), 119.299382998931m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4756), 206.504158950043m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4772), 83.5630119840014m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4789), 245.361990377227m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4806), 123.365771308572m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4824), 223.568631202975m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4840), 46.3702499698446m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4858), 69.3044306237936m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4874), 69.4119939320507m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4892), 182.805138731096m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4908), 111.991783472803m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4954), 238.2928771564m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4972), 191.367778372157m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4990), 75.8197874866235m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5005), 64.2885970566598m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5023), 248.032569757477m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5038), 135.344083381657m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5056), 183.23032768205m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5072), 100.892902984731m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5089), 95.3183577800938m });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantity",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quantity",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quantity",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 4,
                column: "Quantity",
                value: 81);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quantity",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quantity",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quantity",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 8,
                column: "Quantity",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 9,
                column: "Quantity",
                value: 82);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 11,
                column: "Quantity",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 12,
                column: "Quantity",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 13,
                column: "Quantity",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 14,
                column: "Quantity",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 15,
                column: "Quantity",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 16,
                column: "Quantity",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 17,
                column: "Quantity",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 18,
                column: "Quantity",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 19,
                column: "Quantity",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 20,
                column: "Quantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 21,
                column: "Quantity",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 22,
                column: "Quantity",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 23,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 24,
                column: "Quantity",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 25,
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 26,
                column: "Quantity",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 27,
                column: "Quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 28,
                column: "Quantity",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 29,
                column: "Quantity",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 30,
                column: "Quantity",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 31,
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 32,
                column: "Quantity",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 33,
                column: "Quantity",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 34,
                column: "Quantity",
                value: 94);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 35,
                column: "Quantity",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 36,
                column: "Quantity",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 37,
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 38,
                column: "Quantity",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 39,
                column: "Quantity",
                value: 82);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 40,
                column: "Quantity",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 41,
                column: "Quantity",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 42,
                column: "Quantity",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 43,
                column: "Quantity",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 44,
                column: "Quantity",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 45,
                column: "Quantity",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 46,
                column: "Quantity",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 47,
                column: "Quantity",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 48,
                column: "Quantity",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 49,
                column: "Quantity",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 50,
                column: "Quantity",
                value: 86);

            migrationBuilder.UpdateData(
                table: "StockEvent",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "StockEvent",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5918));
        }
    }
}
