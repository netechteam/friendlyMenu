using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("tbladdress")]
    public class tblAddress
    {
        [Column("address_ix")]
        public int Id { get; set; }
        [Column("restaurant_ix")]
        public int RestaurantId { get; set; }
        [Column("street1_s")]
        public string Street1 { get; set; }
        [Column("street2_s")]
        public string Street2 { get; set; }
        [Column("cityname_s")]
        public string CityName { get; set; }
        [Column("statename_s")]
        public string StateName { get; set; }
        [Column("stateabbr_s")]
        public string StateAbbr { get; set; }
        [Column("zip_i")]
        public string Zip { get; set; }
        [Column("country_s")]
        public string Country { get; set; }
        [Column("countryabbr_s")]
        public string CountryAbbr { get; set; }
    }
}
