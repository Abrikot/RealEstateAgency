using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace RealEstateAgency.Model
{
    [Table("person")]
    class Person    : Parameter
    {
        // Attributs
        private int _id;
        private string _last_name;
        private string _first_name;
        private int _phone;
        private int _cellphone;
        private string _mail;
        private string _address;
        private int _zip;
        private string _city;

        // Propriétés
        [Column("id"), PrimaryKey, AutoIncrement]
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
        [Column("last_name"), NotNull]
        public string Last_name
        {
            get
            {
                return _last_name;
            }

            set
            {
                _last_name = value;
            }
        }
        [Column("first_name"), NotNull]
        public string First_name
        {
            get
            {
                return _first_name;
            }

            set
            {
                _first_name = value;
            }
        }
        [Column("phone")]
        public int Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }
        [Column("cellphone")]
        public int Cellphone
        {
            get
            {
                return _cellphone;
            }

            set
            {
                _cellphone = value;
            }
        }
        [Column("mail")]
        public string Mail
        {
            get
            {
                return _mail;
            }

            set
            {
                _mail = value;
            }
        }
        [Column("address")]
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
        [Column("zip")]
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
        [Column("city")]
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
    }
}
