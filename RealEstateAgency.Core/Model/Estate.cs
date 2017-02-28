using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Core.Model
{
    class Estate    : Parameter
    {
        // Enum
        public enum Type { House, Flat, Field, Garage }

        // Attributs
        public int id { get; set; }
        public float surface { get; set; }
        public float surface_carrez { get; set; }
        public int rooms_count { get; set; }
        public string address{ get; set; }
        public int zip { get; set; }
        public string city { get; set; }
        public float estimated_price { get; set; }
        public float annual_charges{ get; set; }
        public float property_taxes{ get; set; }
        public int float_number { get; set; }
        public int floar_count { get; set; }
        public bool elevator { get; set; }
        public int main_photo_id { get; set; }
        public int commercial_id { get; set; }
    }
}
