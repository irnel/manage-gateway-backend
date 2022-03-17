using AutoMapper;
using ManageGateway.Application.DTOs;
using ManageGateway.Domain.Models;

namespace ManageGateway.Application.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<GatewayDTO, Gateway>().ReverseMap();

            CreateMap<GatewayWithDevices, Gateway>().ReverseMap();

            CreateMap<DeviceDTO, Device>().ReverseMap();

            CreateMap<DeviceWithGateway, Device>().ReverseMap();
        }
    }
}
