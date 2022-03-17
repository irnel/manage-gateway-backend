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
                    { "094d23bf-a700-40de-945b-b6419a936085", new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "igDFAY6L", 0, "ANDROID" },
                    { "0f66a4b2-85b3-4757-b1c5-039acf6b3c5d", new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "BGVCDTZA", 0, "XBOX" },
                    { "1eda5082-72be-4982-93fd-bd8a729d3391", new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "5v3VqScu", 0, "HP" },
                    { "28d0151c-880b-4929-bd22-aacd07a24b06", new DateTime(2009, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BGVCDTZA", 0, "LENOVO" },
                    { "2afb4b53-1315-495c-88c1-441257418db0", new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "igDFAY6L", 1, "IMAC" },
                    { "368436d2-6629-443a-a039-cb130a0ea529", new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "5v3VqScu", 1, "PRINTER" },
                    { "4726f25f-cee8-4905-bfd9-9e3bebdda731", new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "igDFAY6L", 1, "IPHONE 13" },
                    { "4e24c3be-a634-4388-9002-2f6b4405b655", new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "DQzrzFZZ", 0, "IBM" },
                    { "540b1edb-0bc2-4cde-94c2-748df32bd1e6", new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BGVCDTZA", 0, "MICROSOFT" },
                    { "62f4e2e9-3a72-4083-88f1-eb821b436d3b", new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "5v3VqScu", 0, "HDD" },
                    { "75cee42e-fc2f-45db-9ccc-e785af14bba6", new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "5jTocfWo", 1, "APPLE TV" },
                    { "8362becf-84d5-4914-9ed9-dc818c01770b", new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "5v3VqScu", 0, "ACER" },
                    { "83b7e031-d4d9-41a3-9e12-f0ff080e367a", new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "igDFAY6L", 0, "IPAD" },
                    { "863ed4bd-7294-406a-aec5-731dabe5b704", new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "5v3VqScu", 1, "THOSIBA" },
                    { "8666dbc0-5e18-44bd-8f40-e96fa020afaa", new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "BGVCDTZA", 0, "PANASONIC" },
                    { "8e309713-e9b4-449d-a039-1781b7d8642f", new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "5v3VqScu", 0, "INTEL" },
                    { "b587f427-01cb-4e5e-b0c1-9cfa914eab61", new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "igDFAY6L", 1, "AMD" },
                    { "c103fede-a624-4281-9c70-3b3dc2ebdee3", new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "igDFAY6L", 0, "IPHONE XS" },
                    { "c3c182d2-854f-4555-8b82-76a87a115aa6", new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "5jTocfWo", 0, "APPLE WATCH" },
                    { "c80dcf46-5d21-4f2a-b5a8-ecdc2911aa69", new DateTime(2018, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "igDFAY6L", 0, "SURFACE PRO" },
                    { "e4c13cf3-006c-40ab-91da-d2924ecf11c3", new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "5v3VqScu", 0, "SSD" },
                    { "e4ea378c-f99a-482e-ac44-2ae7db111bf0", new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DQzrzFZZ", 0, "SAMSUNG" },
                    { "f0606a1f-eb6d-4357-adbf-0ad765700465", new DateTime(2018, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "BGVCDTZA", 1, "PLAY STATION" },
                    { "f5fe8ce4-4b58-45ab-a802-f14989f8c9f3", new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "DQzrzFZZ", 1, "APPLE" }
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
