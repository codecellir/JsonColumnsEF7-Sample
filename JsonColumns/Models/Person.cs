namespace JsonColumns.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Contact Contact { get; set; }

        public List<Statistic> Statistics { get; set; }
    }


    public class Contact
    {
        public string Phone { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
    }

    public class Statistic
    {
        public string Key { get; set; }
        public List<StatisticDetail> Details { get; set; }
    }
    public class StatisticDetail
    {
        public string Term { get; set; }
        public int Count { get; set; }
    }
}
