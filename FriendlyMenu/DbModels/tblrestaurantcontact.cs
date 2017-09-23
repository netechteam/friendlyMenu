using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("tblrestaurantcontact")]
    public class tblRestaurantContact
    {
        [Column("restaurantcontact_ix")]
        public int Id { get; set; }
        [Column("restaurant_ix")]
        public int RestaurantId { get; set; }
        [Column("staffname_s")]
        public string StaffName { get; set; }
        [Column("phonemain_s")]
        public string PhoneMain { get; set; }
        [Column("phonealt_s")]
        public string PhoneAlt { get; set; }
        [Column("fax_s")]
        public string Fax { get; set; }
        [Column("email_s")]
        public string Email { get; set; }
    }
}
