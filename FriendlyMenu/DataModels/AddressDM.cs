namespace DataModels
{
    public class AddressDM
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string StateAbbr { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string CountryAbbr { get; set; }
    }
}
