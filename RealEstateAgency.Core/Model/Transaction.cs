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
        private int _id;
        private int _estate_id;
        private bool _furnished;
        private float _proposal_price;
        private float _real_price;
        private float _proposal_fees;
        private float _real_fees;
        private string _title;
        private string _description;
        private DateTime _publication_date;
        private DateTime _transaction_date;
        private bool _transaction_done;
        private int _client_id;
        private int _owner_id;

        // Propriétés
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public int Estate_id
        {
            get
            {
                return _estate_id;
            }

            set
            {
                _estate_id = value;
            }
        }

        public bool Furnished
        {
            get
            {
                return _furnished;
            }

            set
            {
                _furnished = value;
            }
        }

        public float Proposal_price
        {
            get
            {
                return _proposal_price;
            }

            set
            {
                _proposal_price = value;
            }
        }

        public float Real_price
        {
            get
            {
                return _real_price;
            }

            set
            {
                _real_price = value;
            }
        }

        public float Proposal_fees
        {
            get
            {
                return _proposal_fees;
            }

            set
            {
                _proposal_fees = value;
            }
        }

        public float Real_fees
        {
            get
            {
                return _real_fees;
            }

            set
            {
                _real_fees = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public DateTime Publication_date
        {
            get
            {
                return _publication_date;
            }

            set
            {
                _publication_date = value;
            }
        }

        public DateTime Transaction_date
        {
            get
            {
                return _transaction_date;
            }

            set
            {
                _transaction_date = value;
            }
        }

        public bool Transaction_done
        {
            get
            {
                return _transaction_done;
            }

            set
            {
                _transaction_done = value;
            }
        }

        public int Client_id
        {
            get
            {
                return _client_id;
            }

            set
            {
                _client_id = value;
            }
        }

        public int Owner_id
        {
            get
            {
                return _owner_id;
            }

            set
            {
                _owner_id = value;
            }
        }
    }
}
