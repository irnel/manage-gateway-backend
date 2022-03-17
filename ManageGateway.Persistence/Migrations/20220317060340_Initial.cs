using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManageGateway.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gateways",
                columns: table => new
                {
                    SerialNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gateways", x => x.SerialNumber);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    UID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Vendor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    GatewaySerialNumber = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.UID);
                    table.ForeignKey(
                        name: "FK_Devices_Gateways_GatewaySerialNumber",
                        column: x => x.GatewaySerialNumber,
                        principalTable: "Gateways",
                        principalColumn: "SerialNumber");
                });

            migrationBuilder.InsertData(
                table: "Gateways",
                columns: new[] { "SerialNumber", "Address", "Name" },
                values: new object[,]
                {
                    { "5jTocfWo", "169.32.116.241", "Gateway3" },
                    { "5v3VqScu", "99.252.137.28", "Gateway4" },
                    { "BGVCDTZA", "96.181.47.91", "Gateway2" },
                    { "DQzrzFZZ", "122.236.174.239", "Gateway1" },
                    { "igDFAY6L", "241.232.209.216", "Gateway5" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "UID", "CreatedDate", "GatewaySerialNumber", "Status", "Vendor" },
                values: new object[,]
                {
                    { "03a40e3a-be03-4f28-9b6c-cf8e0f4a92e9", new DateTime(2012, 3, 17, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7279), "DQzrzFZZ", 1, "IBM" },
                    { "152c1302-6ebb-40b2-881d-ff1454a15612", new DateTime(2011, 10, 27, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7404), "5v3VqScu", 1, "HDD" },
                    { "15a46dbc-e86a-4511-8c78-59608b2333da", new DateTime(2011, 1, 27, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7416), "5v3VqScu", 0, "THOSIBA" },
                    { "1aa04704-59d7-4da2-b8b6-f91b5950512b", new DateTime(2014, 5, 16, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7457), "igDFAY6L", 1, "IPHONE XS" },
                    { "2bc84467-eace-42b5-b2c8-689c934f77df", new DateTime(2001, 5, 16, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7427), "5v3VqScu", 1, "INTEL" },
                    { "2cd05870-18d2-40cb-8f6c-9e15e597ca6a", new DateTime(2001, 12, 17, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7346), "BGVCDTZA", 1, "MICROSOFT" },
                    { "38a56917-481b-4802-88ed-42c7f296f0af", new DateTime(2001, 5, 16, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7436), "igDFAY6L", 0, "AMD" },
                    { "51b9386e-8d28-4d98-a1ef-f3fc536cd172", new DateTime(2019, 7, 18, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7386), "5jTocfWo", 1, "APPLE WATCH" },
                    { "55012c37-8558-429b-97ec-b7d548ba9360", new DateTime(2001, 10, 27, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7357), "BGVCDTZA", 0, "PLAY STATION" },
                    { "62a5f3cc-3201-4dc5-965a-4b6112779bd2", new DateTime(2022, 3, 17, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7446), "igDFAY6L", 1, "IPAD" },
                    { "76f928f5-3d01-4ae6-853e-c7b37eba70dc", new DateTime(2010, 1, 17, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7351), "BGVCDTZA", 1, "XBOX" },
                    { "7955fb66-de2f-4bae-8556-09954820afb3", new DateTime(2001, 8, 18, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7451), "igDFAY6L", 0, "IPHONE 13" },
                    { "98aaee50-e016-4238-8a98-b97ce10cdbb5", new DateTime(2012, 5, 16, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7462), "igDFAY6L", 1, "SURFACE PRO" },
                    { "a7a82e27-3fce-4d41-a9f3-16e72d71648a", new DateTime(2002, 8, 27, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7422), "5v3VqScu", 1, "ACER" },
                    { "a991adf0-c8de-4434-bbcf-0bcf850a1a98", new DateTime(2001, 10, 17, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7333), "DQzrzFZZ", 1, "SAMSUNG" },
                    { "b1284ada-7fe9-4984-902b-363cd3ea9848", new DateTime(2002, 2, 27, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7398), "5v3VqScu", 0, "PRINTER" },
                    { "b3469b25-2015-48dc-a357-e52396fa6bf0", new DateTime(1998, 10, 18, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7377), "5jTocfWo", 0, "APPLE TV" },
                    { "bd26d119-eea1-44c8-b9f0-47c2c0656ac3", new DateTime(2022, 3, 17, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7441), "igDFAY6L", 1, "ANDROID" },
                    { "c4f14cf8-009c-40e2-b836-dfb913dba481", new DateTime(2006, 9, 17, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7340), "DQzrzFZZ", 0, "APPLE" },
                    { "cd0598c0-0bf0-4a22-94e1-011895510f03", new DateTime(2001, 7, 2, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7410), "5v3VqScu", 1, "SSD" },
                    { "cd272b6f-a33d-46f5-b298-c1a883a9ed47", new DateTime(2012, 5, 16, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7468), "igDFAY6L", 0, "IMAC" },
                    { "e71cbf4b-e654-4ddf-8ab7-f8e0a0048a91", new DateTime(1996, 7, 27, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7365), "BGVCDTZA", 1, "LENOVO" },
                    { "ef7cd65a-b263-4496-ace0-5fcf9f1fc54a", new DateTime(2001, 10, 27, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7371), "BGVCDTZA", 1, "PANASONIC" },
                    { "f7276d90-21b1-4395-844c-600b120ee17b", new DateTime(1996, 10, 27, 2, 3, 39, 890, DateTimeKind.Local).AddTicks(7392), "5v3VqScu", 1, "HP" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_GatewaySerialNumber",
                table: "Devices",
                column: "GatewaySerialNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Gateways");
        }
    }
}
