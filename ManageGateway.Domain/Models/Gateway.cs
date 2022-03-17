using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.ComponentModel.DataAnnotations;

namespace ManageGateway.Domain.Models
{
    public class Gateway
    {
        [Key]
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Device> Devices { get; set;}
    }
}
