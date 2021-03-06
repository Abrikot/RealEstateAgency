﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace RealEstateAgency.Model
{
    [Table("estate")]
    public class Estate : ViewModels.BaseNotifyPropertyChanged
    {

        // Enum
        public enum Type { House, Flat, Field, Garage }

        // Attributs
        private int _id;
        private Type _type = Type.Field;
        private float? _surface;
        private float? _surface_carrez;
        private int? _rooms_count;
        private string _address;
        private int? _zip;
        private string _city;
        private float? _estimated_price;
        private float? _annual_charges;
        private float? _property_taxes;
        private int? _floor_number;
        private int? _floor_count;
        private bool? _elevator;
        private int? _main_photo_id;
        private int? _commercial_id;

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
        [Column("type")]
        public Type EstateType
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
        [Column("surface")]
        public float? Surface
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
        [Column("surface_carrez")]
        public float? SurfaceCarrez
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
        [Column("rooms_count")]
        public int? RoomsCount
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
        public int? Zip
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
        [Column("esimated_price")]
        public float? EstimatedPrice
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
        [Column("annual_charges")]
        public float? AnnualCharges
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
        [Column("property_taxes")]
        public float? PropertyTaxes
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
        [Column("floor_number")]
        public int? FloorNumber
        {
            get
            {
                return _floor_number;
            }

            set
            {
                _floor_number = value;
            }
        }
        [Column("floor_count")]
        public int? FloorCount
        {
            get
            {
                return _floor_count;
            }

            set
            {
                _floor_count = value;
            }
        }
        [Column("elevator")]
        public bool? Elevator
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
        [Column("main_photo_id")]
        public int? MainPhotoId
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
        [Column("commercial_id")]
        public int? CommercialId
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
