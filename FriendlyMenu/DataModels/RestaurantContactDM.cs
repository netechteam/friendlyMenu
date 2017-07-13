namespace DataModels
{
    public class RestaurantContactDM
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string StaffName { get; set; }
        public string PhoneMain { get; set; }
        public string PhoneAlt { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }
}
