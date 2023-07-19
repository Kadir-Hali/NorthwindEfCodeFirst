namespace NorthwindEfCodeFirst.Entities;

public class Customer
{
    public Customer()
    {
        Orders = new List<Order>();  //Object null referance hatası almamak için
    }

    public string CustomerID { get; set; }
    public string ContactName { get; set; }
    public string CompanyName { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public List<Order> Orders { get; set; }
}