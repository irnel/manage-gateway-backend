using AutoMapper;
using ManageGateway.Application.DTOs;
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
    public class DeviceTestController
    {
        Mock<IDeviceService> _mockService;
        DeviceController _controller;
        readonly IMapper _mapper;

        public DeviceTestController()
        {
           if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MapperProfile());
                });

                _mapper = mappingConfig.CreateMapper();
            }

            _mockService = new Mock<IDeviceService>();
            _controller = new DeviceController(_mockService.Object, _mapper);
        }

        [Fact]
        public async Task GetById_ShouldReturnDevice_And_OkResult_WhenDeviceExists()
        {
            // Arrange
            var deviceUID = GenerateRandomGUID();
            var device = GetDevice();
            device.UID = deviceUID;

            _mockService.Setup(s => s.GetByIdAsync(deviceUID)).ReturnsAsync(device);

            // Act
            var actionResult = await _controller.GetByIdAsync(deviceUID);
            var resultValue = actionResult.GetObjectResult();

            // Assert
            Assert.NotNull(resultValue);
            Assert.Equal(device.UID, deviceUID);
            Assert.IsType<OkObjectResult>(actionResult.Result);
        }

        [Fact]
        public async Task GetAllDevices_ShouldReturnDevices_AndOkResult_WhenDevicesExists()
        {
            // Arrange
            var devices = GetDevices();
            _mockService.Setup(s => s.GetAllAsync()).ReturnsAsync(devices);

            // Act
            var actionResult = await _controller.GetAllAsync();
            var resultValue = actionResult.GetObjectResult();

            // Assert
            Assert.NotNull(resultValue);
            Assert.True((resultValue as IReadOnlyList<object>).Count > 0);
            Assert.IsType<OkObjectResult> (actionResult.Result);
        }

        [Fact]
        public async Task AddDevice_ShouldReturnNoContent_WhenModelDeviceIsValid()
        {
            // Arrange
            var device = new DeviceDTO
            {
                Vendor = "MusalaSoft",
                CreatedDate = DateTime.Now,
                Status = DeviceStatus.Online,
                GatewaySerialNumber = "igDFAY6L",
            };

            _mockService.Setup(s => s.AddAsync(It.IsAny<Device>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var actionResult = await _controller.AddAsync(device);

            // Arrange
            Assert.IsType<NoContentResult>(actionResult);
            _mockService.Verify();
        }

        #region Helper Methods

        internal Device GetDevice()
        {
            return new Device
            {
                Vendor = "MusalaSoft",
                CreatedDate = DateTime.Now,
                Status = DeviceStatus.Online,
                GatewaySerialNumber = "igDFAY6L"
            };
        }

        internal IReadOnlyList<Device> GetDevices()
        {
            var devices = new List<Device>
            {
                new Device
                {
                    UID = GenerateRandomGUID(),
                    Vendor = "MusalaSoft1",
                    CreatedDate = DateTime.Now,
                    Status = DeviceStatus.Online,
                    GatewaySerialNumber = "igDFAY6L"
                },
                new Device
                {
                    UID = GenerateRandomGUID(),
                    Vendor = "MusalaSoft2",
                    CreatedDate = DateTime.Now,
                    Status = DeviceStatus.Online,
                    GatewaySerialNumber = "igDFAY6L"
                },
                new Device
                {
                    UID = GenerateRandomGUID(),
                    Vendor = "MusalaSoft3",
                    CreatedDate = DateTime.Now,
                    Status = DeviceStatus.Online,
                    GatewaySerialNumber = "igDFAY6L"
                },
                new Device
                {
                    UID = GenerateRandomGUID(),
                    Vendor = "MusalaSoft4",
                    CreatedDate = DateTime.Now,
                    Status = DeviceStatus.Online,
                    GatewaySerialNumber = "igDFAY6L"
                },
                new Device
                {
                    UID = GenerateRandomGUID(),
                    Vendor = "MusalaSoft5",
                    CreatedDate = DateTime.Now,
                    Status = DeviceStatus.Online,
                    GatewaySerialNumber = "igDFAY6L"
                },
            };

            return devices;
        }

        internal string GenerateRandomGUID() => Guid.NewGuid().ToString();

        #endregion

    }
}
