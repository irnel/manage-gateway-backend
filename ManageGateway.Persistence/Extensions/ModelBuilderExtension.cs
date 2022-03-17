using ManageGateway.Domain.Enums;
using ManageGateway.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

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
                    CreatedDate = DateTime.Now.AddYears(-10),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "DQzrzFZZ",
                    Vendor = "SAMSUNG",
                    CreatedDate = DateTime.Now.AddYears(-20).AddMonths(-5),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "DQzrzFZZ",
                    Vendor = "APPLE",
                    CreatedDate = DateTime.Now.AddYears(-15).AddMonths(-6),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "BGVCDTZA",
                    Vendor = "MICROSOFT",
                    CreatedDate = DateTime.Now.AddYears(-20).AddMonths(-3),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "BGVCDTZA",
                    Vendor = "XBOX",
                    CreatedDate = DateTime.Now.AddYears(-12).AddMonths(-2),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "BGVCDTZA",
                    Vendor = "PLAY STATION",
                    CreatedDate = DateTime.Now.AddYears(-20).AddMonths(-5).AddDays(10),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "BGVCDTZA",
                    Vendor = "LENOVO",
                    CreatedDate = DateTime.Now.AddYears(-25).AddMonths(-8).AddDays(10),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "BGVCDTZA",
                    Vendor = "PANASONIC",
                    CreatedDate = DateTime.Now.AddYears(-20).AddMonths(-5).AddDays(10),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5jTocfWo",
                    Vendor = "APPLE TV",
                    CreatedDate = DateTime.Now.AddYears(-23).AddMonths(-5).AddDays(1),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5jTocfWo",
                    Vendor = "APPLE WATCH",
                    CreatedDate = DateTime.Now.AddYears(-2).AddMonths(-8).AddDays(1),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "HP",
                    CreatedDate = DateTime.Now.AddYears(-25).AddMonths(-5).AddDays(10),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "PRINTER",
                    CreatedDate = DateTime.Now.AddYears(-20).AddMonths(-1).AddDays(10),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "HDD",
                    CreatedDate = DateTime.Now.AddYears(-10).AddMonths(-5).AddDays(10),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "SSD",
                    CreatedDate = DateTime.Now.AddYears(-20).AddMonths(-9).AddDays(15),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "THOSIBA",
                    CreatedDate = DateTime.Now.AddYears(-11).AddMonths(-2).AddDays(10),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "ACER",
                    CreatedDate = DateTime.Now.AddYears(-20).AddMonths(5).AddDays(10),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "5v3VqScu",
                    Vendor = "INTEL",
                    CreatedDate = DateTime.Now.AddYears(-21).AddMonths(2).AddDays(-1),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "AMD",
                    CreatedDate = DateTime.Now.AddYears(-21).AddMonths(2).AddDays(-1),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "ANDROID",
                    CreatedDate = DateTime.Now,
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "IPAD",
                    CreatedDate = DateTime.Now,
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "IPHONE 13",
                    CreatedDate = DateTime.Now.AddYears(-21).AddMonths(5).AddDays(1),
                    Status = DeviceStatus.Offline
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "IPHONE XS",
                    CreatedDate = DateTime.Now.AddYears(-8).AddMonths(2).AddDays(-1),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "SURFACE PRO",
                    CreatedDate = DateTime.Now.AddYears(-10).AddMonths(2).AddDays(-1),
                    Status = DeviceStatus.Online
                },
                new Device
                {
                    UID = Guid.NewGuid().ToString(),
                    GatewaySerialNumber = "igDFAY6L",
                    Vendor = "IMAC",
                    CreatedDate = DateTime.Now.AddYears(-10).AddMonths(2).AddDays(-1),
                    Status = DeviceStatus.Offline
                }
            );
        }
    }
}
