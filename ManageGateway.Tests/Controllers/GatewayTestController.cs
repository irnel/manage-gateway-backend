using AutoMapper;
using ManageGateway.Application.Interfaces.Services;
using ManageGateway.Application.Mappers;
using ManageGateway.Domain.Enums;
using ManageGateway.Domain.Models;
using ManageGateway.Server.Controllers;
using ManageGateway.Tests.Extensions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ManageGateway.Tests.Controllers
{
    public class GatewayTestController
    {
        readonly Mock<IGatewayService> _mockService;
        readonly GatewayController _controller;
        readonly IMapper _mapper;

        public GatewayTestController()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MapperProfile());
                });

                _mapper = mappingConfig.CreateMapper();
            }

            _mockService = new Mock<IGatewayService>();
            _controller = new GatewayController(_mockService.Object, _mapper);
        }

        [Fact]
        public async Task GetById_ShouldReturnGateway_And_OkResult_WhenGatewayExists()
        {
            // Arrange
            var serialNumber = "igDFAY6LPX";
            var gateway = GetGateway();
            gateway.SerialNumber = serialNumber;

            _mockService.Setup(s => s.GetByIdAsync(serialNumber)).ReturnsAsync(gateway);

            // Act
            var actionResult = await _controller.GetByIdAsync(serialNumber);
            var resultValue = actionResult.GetObjectResult();

            // Assert
            Assert.NotNull(resultValue);
            Assert.Equal(gateway.SerialNumber, serialNumber);
            Assert.IsType<OkObjectResult>(actionResult.Result);
        }

        [Fact]
        public async Task GetById_ShouldReturnNotFound_WhenGatewayNotExists()
        {
            // Arrange
            var fakeSerialNumber = "igDZX3FAY6LG";
            Gateway fakeGateway = null;

            _mockService.Setup(s => s.GetByIdAsync(fakeSerialNumber)).ReturnsAsync(fakeGateway);

            // Act
            var actionResult = await _controller.GetByIdAsync(fakeSerialNumber);
            var resultValue = actionResult.Result;

            // Assert
            Assert.True(fakeGateway is null);
            Assert.IsType<NotFoundResult>(actionResult.Result);
        }

        [Fact]
        public async Task GetAllGateways_ShouldReturnDevices_AndOkResult_WhenGatewaysExists()
        {
            // Arrange
            var gateways = GetGateways();
            _mockService.Setup(s => s.GetAllAsync()).ReturnsAsync(gateways);

            // Act
            var actionResult = await _controller.GetAllAsync();
            var resultValue = actionResult.GetObjectResult();

            // Assert
            Assert.NotNull(resultValue);
            Assert.True((resultValue as IReadOnlyList<object>).Count > 0);
            Assert.IsType<OkObjectResult>(actionResult.Result);
        }

        #region Helper Methods

        internal Gateway GetGateway()
        {
            return new Gateway
            {
                Name = "Gateway1X",
                Address = "122.236.174.239",
                Devices = new List<Device>
                {
                    new Device
                    {
                        UID = GenerateRandomGUID(),
                        Vendor = "MusalaSoft1",
                        CreatedDate = DateTime.Now,
                        Status = DeviceStatus.Online,
                        GatewaySerialNumber = "DQzrzFZZQ9",
                    },
                    new Device
                    {
                        UID = GenerateRandomGUID(),
                        Vendor = "MusalaSoft2",
                        CreatedDate = DateTime.Now,
                        Status = DeviceStatus.Online,
                        GatewaySerialNumber = "DQzrzFZZQ9",
                    }
                }
            };
        }

        internal IReadOnlyList<Gateway> GetGateways()
        {
            var devices = new List<Gateway>
            {
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
            };

            return devices;
        }

        internal string GenerateRandomGUID() => Guid.NewGuid().ToString();

        #endregion
    }
}
