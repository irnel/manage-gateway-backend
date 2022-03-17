namespace ManageGateway.Application.DTOs
{
    public class GatewayWithDevices
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<DeviceDTO> Devices { get; set; }
    }
}
