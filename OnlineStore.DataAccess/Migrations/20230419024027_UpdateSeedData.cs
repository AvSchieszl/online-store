using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineStore.DataAccess.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClerkId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_User_ClerkId",
                        column: x => x.ClerkId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_User_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockEvent_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "ClerkId", "CreatedAt", "CustomerId", "IsDeleted" },
                values: new object[] { 1, 2, new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5937), 3, false });

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
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4601), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 180.314387417907m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4623), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 245.245236145053m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4643), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 33.1545869158288m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4661), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 32.79672785384m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4721), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 151.509911691045m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4739), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 119.299382998931m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4756), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 206.504158950043m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4772), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 83.5630119840014m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4789), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 245.361990377227m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4806), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 123.365771308572m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4824), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 223.568631202975m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4840), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 46.3702499698446m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4858), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 69.3044306237936m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4874), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 69.4119939320507m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4892), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 182.805138731096m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4908), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 111.991783472803m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4954), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 238.2928771564m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4972), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 191.367778372157m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(4990), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 75.8197874866235m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5005), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 64.2885970566598m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5023), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 248.032569757477m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5038), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 135.344083381657m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5056), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 183.23032768205m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5072), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 100.892902984731m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5089), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 95.3183577800938m });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "Id", "Order", "Path", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 1 },
                    { 2, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 2 },
                    { 3, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 3 },
                    { 4, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 4 },
                    { 5, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 5 },
                    { 6, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 6 },
                    { 7, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 7 },
                    { 8, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 8 },
                    { 9, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 9 },
                    { 10, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 10 },
                    { 11, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 11 },
                    { 12, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 12 },
                    { 13, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 13 },
                    { 14, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 14 },
                    { 15, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 15 },
                    { 16, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 16 },
                    { 17, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 17 },
                    { 18, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 18 },
                    { 19, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 19 },
                    { 20, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 20 },
                    { 21, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 21 },
                    { 22, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 22 },
                    { 23, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 23 },
                    { 24, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 24 },
                    { 25, 1, "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 25 },
                    { 26, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 26 },
                    { 27, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 27 },
                    { 28, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 28 },
                    { 29, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 29 },
                    { 30, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 30 },
                    { 31, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 31 },
                    { 32, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 32 },
                    { 33, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 33 }
                });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "Id", "Order", "Path", "ProductId" },
                values: new object[,]
                {
                    { 34, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 34 },
                    { 35, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 35 },
                    { 36, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 36 },
                    { 37, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 37 },
                    { 38, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 38 },
                    { 39, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 39 },
                    { 40, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 40 },
                    { 41, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 41 },
                    { 42, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 42 },
                    { 43, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 43 },
                    { 44, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 44 },
                    { 45, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 45 },
                    { 46, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 46 },
                    { 47, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 47 },
                    { 48, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 48 },
                    { 49, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 49 },
                    { 50, 1, "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80", 50 }
                });

            migrationBuilder.InsertData(
                table: "Stock",
                columns: new[] { "Id", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 8 },
                    { 2, 2, 32 },
                    { 3, 3, 12 },
                    { 4, 4, 81 },
                    { 5, 5, 49 },
                    { 6, 6, 14 },
                    { 7, 7, 52 },
                    { 8, 8, 14 },
                    { 9, 9, 82 },
                    { 10, 10, 34 },
                    { 11, 11, 96 },
                    { 12, 12, 76 },
                    { 13, 13, 61 },
                    { 14, 14, 12 },
                    { 15, 15, 19 },
                    { 16, 16, 70 },
                    { 17, 17, 83 },
                    { 18, 18, 66 },
                    { 19, 19, 85 },
                    { 20, 20, 2 },
                    { 21, 21, 13 },
                    { 22, 22, 11 },
                    { 23, 23, 10 },
                    { 24, 24, 71 },
                    { 25, 25, 1 }
                });

            migrationBuilder.InsertData(
                table: "Stock",
                columns: new[] { "Id", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 26, 26, 24 },
                    { 27, 27, 3 },
                    { 28, 28, 39 },
                    { 29, 29, 59 },
                    { 30, 30, 53 },
                    { 31, 31, 5 },
                    { 32, 32, 72 },
                    { 33, 33, 7 },
                    { 34, 34, 94 },
                    { 35, 35, 56 },
                    { 36, 36, 85 },
                    { 37, 37, 5 },
                    { 38, 38, 11 },
                    { 39, 39, 82 },
                    { 40, 40, 7 },
                    { 41, 41, 21 },
                    { 42, 42, 24 },
                    { 43, 43, 56 },
                    { 44, 44, 44 },
                    { 45, 45, 70 },
                    { 46, 46, 56 },
                    { 47, 47, 22 },
                    { 48, 48, 14 },
                    { 49, 49, 43 },
                    { 50, 50, 86 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 2, 100m },
                    { 2, 1, 26, 1, 75m }
                });

            migrationBuilder.InsertData(
                table: "StockEvent",
                columns: new[] { "Id", "CreatedAt", "Quantity", "Reason", "StockId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5916), 50, "Initial stock", 1, 1 },
                    { 2, new DateTime(2023, 4, 19, 9, 40, 26, 713, DateTimeKind.Local).AddTicks(5918), 30, "Restock", 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClerkId",
                table: "Order",
                column: "ClerkId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ProductId",
                table: "Stock",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockEvent_StockId",
                table: "StockEvent",
                column: "StockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "StockEvent");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(8920), 197.943814690336m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(8979), 87.9826435260168m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9016), 142.709559623566m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9050), 103.451500665276m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9084), 23.5596236145376m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9116), 99.0925097454869m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9261), 155.67458978636m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9293), 34.4776874063506m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9325), 198.479698559333m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9358), 44.6122586608008m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9391), 211.089611254976m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9421), 226.23493521835m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9454), 171.977971235181m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9484), 131.26129956166m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9517), 20.1915342625744m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9547), 168.654211735008m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9580), 190.484411164399m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9612), 209.97307048257m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9694), 186.808155066922m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9724), 96.3239702582256m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9757), 123.986300538768m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9786), 108.190701277961m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9819), 81.899055651364m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9849), 134.505413297666m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9882), 128.664638158353m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(8948), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 122.806139303936m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(8986), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 177.938595438653m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9022), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 199.551727586247m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9056), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 160.239314697244m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9090), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 177.146514575256m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9122), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 235.452422832959m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9267), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 124.577748343943m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9298), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 39.2454725073773m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9331), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 140.493437346835m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9364), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 202.011190316824m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9397), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 86.0234051662821m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9427), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 65.4891405250716m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9460), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 123.943939714192m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9490), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 212.9139504308m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9523), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 145.417045376529m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9553), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 115.458207062096m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9585), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 183.446026784899m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9665), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 97.4165536695294m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9700), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 232.002777711255m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9730), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 84.5307566797162m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9763), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 102.163259176565m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9792), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 102.876163985139m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9825), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 131.331129156638m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9855), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 85.0041968412638m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Thumbnail", "UnitPrice" },
                values: new object[] { new DateTime(2023, 4, 17, 20, 35, 28, 673, DateTimeKind.Local).AddTicks(9888), "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80\r\n", 73.4944285572363m });
        }
    }
}
