using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Core.Model
{
    class Person    : Parameter
    {
        public int id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public int phone { get; set; }
        public int cellphone { get; set; }
        public string mail { get; set; }
        public string address { get; set; }
        public int zip { get; set; }
        public string city { get; set; }
    }
}
