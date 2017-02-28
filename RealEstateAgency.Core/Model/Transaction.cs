using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Core.Model
{
    class Transaction   : Parameter
    {
        // Enum
        public enum Sale_or_Rent { Sale, Rent }

        // Attributs
        public int id { get; set; }
        public int estate_id { get; set; }
        public bool furnished { get; set; }
        public float proposal_price { get; set; }
        public float real_price { get; set; }
        public float proposal_fees { get; set; }
        public float real_fees { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime publication_date { get; set; }
        public DateTime transaction_date { get; set; }
        public bool transaction_done { get; set; }
        public int client_id { get; set; }
        public int owner_id { get; set; }
    }
}
