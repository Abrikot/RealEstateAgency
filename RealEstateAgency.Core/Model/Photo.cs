using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Core.Model
{
    class Photo : Parameter
    {
        // Attributs
        private int _id;
        private int _estate_id;
        private string _title;
        private string _photo_base64;
        private DateTime _shooting_date;

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

        public string Photo_base64
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

        public DateTime Shooting_date
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
