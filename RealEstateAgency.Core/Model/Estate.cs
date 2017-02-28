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
        private int _id;
        private float _surface;
        private float _surface_carrez;
        private int _rooms_count;
        private string _address;
        private int _zip;
        private string _city;
        private float _estimated_price;
        private float _annual_charges;
        private float _property_taxes;
        private int _float_number;
        private int _floar_count;
        private bool _elevator;
        private int _main_photo_id;
        private int _commercial_id;

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
        public float Surface
        {
            get
            {
                return _surface;
            }

            set
            {
                _surface = value;
            }
        }
        public float Surface_carrez
        {
            get
            {
                return _surface_carrez;
            }

            set
            {
                _surface_carrez = value;
            }
        }
        public int Rooms_count
        {
            get
            {
                return _rooms_count;
            }

            set
            {
                _rooms_count = value;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }
        public int Zip
        {
            get
            {
                return _zip;
            }

            set
            {
                _zip = value;
            }
        }
        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }
        public float Estimated_price
        {
            get
            {
                return _estimated_price;
            }

            set
            {
                _estimated_price = value;
            }
        }
        public float Annual_charges
        {
            get
            {
                return _annual_charges;
            }

            set
            {
                _annual_charges = value;
            }
        }
        public float Property_taxes
        {
            get
            {
                return _property_taxes;
            }

            set
            {
                _property_taxes = value;
            }
        }
        public int Float_number
        {
            get
            {
                return _float_number;
            }

            set
            {
                _float_number = value;
            }
        }
        public int Floar_count
        {
            get
            {
                return _floar_count;
            }

            set
            {
                _floar_count = value;
            }
        }
        public bool Elevator
        {
            get
            {
                return _elevator;
            }

            set
            {
                _elevator = value;
            }
        }
        public int Main_photo_id
        {
            get
            {
                return _main_photo_id;
            }

            set
            {
                _main_photo_id = value;
            }
        }
        public int Commercial_id
        {
            get
            {
                return _commercial_id;
            }

            set
            {
                _commercial_id = value;
            }
        }
    }
}
