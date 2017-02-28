using System.Runtime.Serialization;
using SQLite.Net.Attributes;

namespace RealEstateAgency.Model
{
    [Table("parameters")]
    public class Parameter : ViewModels.BaseNotifyPropertyChanged
    {
        public const string PARAMETER_KEY_DB_VERSION = "DB_VERSION";


        #region Propriétés

        [Column("key"), PrimaryKey]
        public string Key { get { return (string)GetProperty(); } set { SetProperty(value); } }

        [Column("value")]
        public string Value { get { return (string)GetProperty(); } set { SetProperty(value); } }

        #endregion

        public Parameter() : this(false) { }
        public Parameter(bool synchronizeWithContext = false) : base(synchronizeWithContext) { }
    }
}
