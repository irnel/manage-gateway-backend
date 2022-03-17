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
                    { "1801348e-82d7-4889-877d-a618dfe7fef5", new DateTime(1996, 10, 27, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(6), "5v3VqScu", 1, "HP" },
                    { "18223fd6-a17f-4cf0-8ed7-a97db9016c78", new DateTime(2010, 1, 17, 11, 31, 13, 519, DateTimeKind.Local).AddTicks(9955), "BGVCDTZA", 1, "XBOX" },
                    { "2610f42c-e3d7-455f-968d-06bd0f7ccf53", new DateTime(2001, 10, 27, 11, 31, 13, 519, DateTimeKind.Local).AddTicks(9974), "BGVCDTZA", 0, "PLAY STATION" },
                    { "281d9fbd-a156-4baa-a9a8-0ff2ace67841", new DateTime(1998, 10, 18, 11, 31, 13, 519, DateTimeKind.Local).AddTicks(9995), "5jTocfWo", 0, "APPLE TV" },
                    { "3c8547bf-6045-4c6e-aa20-3b8f0370513c", new DateTime(2001, 10, 27, 11, 31, 13, 519, DateTimeKind.Local).AddTicks(9989), "BGVCDTZA", 1, "PANASONIC" },
                    { "3cc16475-42b7-44d8-9f36-3685bceefb13", new DateTime(2012, 5, 16, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(94), "igDFAY6L", 0, "IMAC" },
                    { "5f1965cf-b7d2-4fb3-8965-91c31d7ee8c4", new DateTime(2001, 5, 16, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(60), "igDFAY6L", 0, "AMD" },
                    { "66377769-f0ec-46f4-bac1-002b94adc5ce", new DateTime(2002, 2, 27, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(12), "5v3VqScu", 0, "PRINTER" },
                    { "68655a0b-a355-490a-aaf1-49ec332c7c6b", new DateTime(2011, 1, 27, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(33), "5v3VqScu", 0, "THOSIBA" },
                    { "6cc202db-2539-4efd-97f1-dc18df4db13d", new DateTime(2012, 5, 16, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(88), "igDFAY6L", 1, "SURFACE PRO" },
                    { "6d37d556-06f7-4b96-bb8e-cca16e940cf6", new DateTime(2022, 3, 17, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(65), "igDFAY6L", 1, "ANDROID" },
                    { "79ef3d8a-96bc-4234-8d88-56e6892f84f2", new DateTime(2006, 9, 17, 11, 31, 13, 519, DateTimeKind.Local).AddTicks(9943), "DQzrzFZZ", 0, "APPLE" },
                    { "815ae677-dd2b-4940-8384-fbab7a5e7e76", new DateTime(2011, 10, 27, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(18), "5v3VqScu", 1, "HDD" },
                    { "8f97b005-b9eb-478f-b585-14966dc40cf2", new DateTime(2001, 8, 18, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(74), "igDFAY6L", 0, "IPHONE 13" },
                    { "93567541-3e3c-4fb0-96f6-a7e709d68f0a", new DateTime(2001, 7, 2, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(28), "5v3VqScu", 1, "SSD" },
                    { "95537899-7235-4d85-83fe-fe75aa70400d", new DateTime(2019, 7, 18, 11, 31, 13, 520, DateTimeKind.Local), "5jTocfWo", 1, "APPLE WATCH" },
                    { "99d06cc3-a7af-4fd8-a43c-f306e147bc88", new DateTime(2014, 5, 16, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(82), "igDFAY6L", 1, "IPHONE XS" },
                    { "99fb384a-a236-4cb4-8af3-0b5c40dfe88b", new DateTime(2001, 12, 17, 11, 31, 13, 519, DateTimeKind.Local).AddTicks(9950), "BGVCDTZA", 1, "MICROSOFT" },
                    { "9d92e86e-a14b-47ea-8013-9953cc6a4b6a", new DateTime(2022, 3, 17, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(70), "igDFAY6L", 1, "IPAD" },
                    { "b041246c-66c5-4758-ac1d-69677c5b140b", new DateTime(2002, 8, 27, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(48), "5v3VqScu", 1, "ACER" },
                    { "b1c1c0c0-cd1f-49f9-b2fc-6d4515536230", new DateTime(1996, 7, 27, 11, 31, 13, 519, DateTimeKind.Local).AddTicks(9984), "BGVCDTZA", 1, "LENOVO" },
                    { "cdfb4d07-219d-4742-8677-2d2d4dd85ebf", new DateTime(2001, 5, 16, 11, 31, 13, 520, DateTimeKind.Local).AddTicks(54), "5v3VqScu", 1, "INTEL" },
                    { "db52ad2c-a69c-4674-9523-ccb274b9c04b", new DateTime(2012, 3, 17, 11, 31, 13, 519, DateTimeKind.Local).AddTicks(9897), "DQzrzFZZ", 1, "IBM" },
                    { "eef20c9d-8bb6-489f-9e2d-35ca002299bf", new DateTime(2001, 10, 17, 11, 31, 13, 519, DateTimeKind.Local).AddTicks(9936), "DQzrzFZZ", 1, "SAMSUNG" }
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
