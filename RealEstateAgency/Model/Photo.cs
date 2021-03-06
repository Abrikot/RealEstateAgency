﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace RealEstateAgency.Model
{
    [Table("photo")]
    public class Photo : ViewModels.BaseNotifyPropertyChanged
    {
        // Attributs
        private int _id;
        private int _estate_id;
        private string _title;
        private string _photo_base64;
        private DateTime _shooting_date;

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
        [Column("estate_id")]
        public int EstateId
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
        [Column("title")]
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
        [Column("photo_base64")]
        public string Base64
        {
            get
            {
                return _photo_base64;
            }

            set
            {
                _photo_base64 = value;
            }
        }
        [Column("shootind_date")]
        public DateTime ShootingDate
        {
            get
            {
                return _shooting_date;
            }

            set
            {
                _shooting_date = value;
            }
        }
    }
}
