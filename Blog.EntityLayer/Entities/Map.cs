using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntityLayer.Entities
{
    public class Map
    {
        public int MapId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string MapUrl { get; set; }
    }
}
