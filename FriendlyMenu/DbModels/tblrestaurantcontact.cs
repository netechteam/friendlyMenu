using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("restaurantcontact")]
    public class tblRestaurantContact
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("restaurantid")]
        public int RestaurantId { get; set; }
        [Column("staffname")]
        public string StaffName { get; set; }
        [Column("phonemain")]
        public string PhoneMain { get; set; }
        [Column("phonealt")]
        public string PhoneAlt { get; set; }
        [Column("fax")]
        public string Fax { get; set; }
        [Column("email")]
        public string Email { get; set; }
    }
}
