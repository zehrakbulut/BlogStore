using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntityLayer.Entities
{
    public class Information
    {
        public int InformationId { get; set; }
        public string AddressTitle { get; set; }
        public string AddressDescription { get; set; }
        public string PhoneTitle { get; set; }
        public string Phone { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string ContactTitle { get; set; }
        public string ContactDescription { get; set; }
    }
}
