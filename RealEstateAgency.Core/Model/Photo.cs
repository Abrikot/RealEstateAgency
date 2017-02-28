using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Core.Model
{
    class Photo : Parameter
    {
        public int id { get; set; }
        public int estate_id { get; set; }
        public string title { get; set; }
        public string photo_base64 { get; set; }
        public DateTime shooting_date { get; set; }
    }
}
