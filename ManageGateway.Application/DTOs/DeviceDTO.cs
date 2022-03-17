using ManageGateway.Domain.Enums;

namespace ManageGateway.Application.DTOs
{
    public class DeviceDTO
    {
        public string UID { get; set; } = Guid.NewGuid().ToString();
        public string Vendor { get; set; }
        public DateTime CreatedDate { get; set; }
        public DeviceStatus Status { get; set; }

        public string GatewaySerialNumber { get; set; }
    }
}
