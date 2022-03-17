using ManageGateway.Domain.Enums;
using ManageGateway.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ManageGateway.Persistence.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gateway>().HasData(
                new Gateway
                {
                    SerialNumber = "DQzrzFZZ",
                    Name = "Gateway1",
                    Address = "122.236.174.239",
                },
                new Gateway
                {
                    SerialNumber = "BGVCDTZA",
                    Name = "Gateway2",
                    Address = "96.181.47.91",
                },
                new Gateway
                {
                    SerialNumber = "5jTocfWo",
                    Name = "Gateway3",
                    Address = "169.32.116.241",
                },
                 new Gateway
                 {
                     SerialNumber = "5v3VqScu",
                     Name = "Gateway4",
                     Address = "99.252.137.28",
                 },
                new Gateway
                {
                    SerialNumber = "igDFAY6L",
                    Name = "Gateway5",
                    Address = "241.232.209.216",
                }
            );

            modelBuilder.Entity<Device>().HasData(
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "DQzrzFZZ",
                    Vendor = "IBM",
                    CreatedDate = DateTime.Parse("7/24/2020"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "DQzrzFZZ",
                    Vendor = "SAMSUNG",
                    CreatedDate = DateTime.Parse("12/02/2008"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "DQzrzFZZ",
                    Vendor = "APPLE",
                    CreatedDate = DateTime.Parse("01/20/2021"),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "BGVCDTZA",
                    Vendor = "MICROSOFT",
                    CreatedDate = DateTime.Parse("7/24/2020"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "BGVCDTZA",
                    Vendor = "XBOX",
                    CreatedDate = DateTime.Parse("12/02/2008"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "BGVCDTZA",
                    Vendor = "PLAY STATION",
                    CreatedDate = DateTime.Parse("11/21/2018"),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "BGVCDTZA",
                    Vendor = "LENOVO",
                    CreatedDate = DateTime.Parse("7/24/2009"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "BGVCDTZA",
                    Vendor = "PANASONIC",
                    CreatedDate = DateTime.Parse("10/02/2018"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5jTocfWo",
                    Vendor = "APPLE TV",
                    CreatedDate = DateTime.Parse("01/20/2021"),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5jTocfWo",
                    Vendor = "APPLE WATCH",
                    CreatedDate = DateTime.Parse("7/24/2020"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "HP",
                    CreatedDate = DateTime.Parse("12/02/2008"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "PRINTER",
                    CreatedDate = DateTime.Parse("01/20/2021"),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "HDD",
                    CreatedDate = DateTime.Parse("7/24/2020"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "SSD",
                    CreatedDate = DateTime.Parse("12/02/2008"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "THOSIBA",
                    CreatedDate = DateTime.Parse("01/20/2021"),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "ACER",
                    CreatedDate = DateTime.Parse("7/24/2020"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "INTEL",
                    CreatedDate = DateTime.Parse("12/02/2008"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "AMD",
                    CreatedDate = DateTime.Parse("01/20/2021"),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "ANDROID",
                    CreatedDate = DateTime.Parse("7/24/2020"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "IPAD",
                    CreatedDate = DateTime.Parse("12/02/2008"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "IPHONE 13",
                    CreatedDate = DateTime.Parse("01/20/2021"),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "IPHONE XS",
                    CreatedDate = DateTime.Parse("7/24/2020"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "SURFACE PRO",
                    CreatedDate = DateTime.Parse("12/22/2018"),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "IMAC",
                    CreatedDate = DateTime.Parse("01/27/2021"),
                    Status = DeviceStatus.Offline
                }
            );
        }
    }
}
