using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("address")]
    public class tblAddress
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("restaurantid")]
        public int RestaurantId { get; set; }
        [Column("street1")]
        public string Street1 { get; set; }
        [Column("street2")]
        public string Street2 { get; set; }
        [Column("cityname")]
        public string CityName { get; set; }
        [Column("statename")]
        public string StateName { get; set; }
        [Column("stateabbr")]
        public string StateAbbr { get; set; }
        [Column("zip")]
        public string Zip { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("countryabbr")]
        public string CountryAbbr { get; set; }
    }
}
