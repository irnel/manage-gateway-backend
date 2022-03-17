using ManageGateway.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ManageGateway.Domain.Models
{
    public class Device
    {
        [Key]
        public string UID { get; set; }
        public string Vendor { get; set; }
        public DateTime CreatedDate { get; set; }
        public DeviceStatus Status { get; set; }

        public virtual Gateway Gateway { get; set; }

        public string GatewaySerialNumber { get; set; }
    }
}
