using NorthwindEfCodeFirst.Contexts;
using NorthwindEfCodeFirst.Entities;

//getCustomerName();
//addCustomer();
//addOrderWithCustomer();
//removeOrder();
//updateCustomer();

void updateCustomer()
{
    using (var northwindContext = new NorthwindContext())
    {
        Customer customer = northwindContext.Customers.Find("Kadir");
        customer.Country = "Almanya";
        customer.City = "Berlin";
        northwindContext.SaveChanges();
    }
}

void removeOrder()
{
    using (var northwindContext = new NorthwindContext())
    {
        Order order = northwindContext.Orders.Find(1);
        northwindContext.Orders.Remove(order);
        northwindContext.SaveChanges();
    }
}

void addOrderWithCustomer()
{
    using (var northwindContext = new NorthwindContext())
    {
        Customer customer = northwindContext.Customers.Find("Kadir");
        customer.Orders.Add(new Order
            { OrderID = 1, OrderDate = DateTime.Now, ShipCity = "İzmir", ShipCountry = "Türkiye" });
        northwindContext.SaveChanges();
    }
}

void addCustomer()
{
    using (var northwindContext = new NorthwindContext())
    {
        Customer customer = new Customer
        {
            CustomerID = "Kadir", ContactName = "Kadir Halı", City = "Antalya", CompanyName = "İksir",
            Country = "Türkiye"
        };
        northwindContext.Customers.Add(customer);
        northwindContext.SaveChanges();
    }
}

void getCustomerName()
{
    using (var northwindContext = new NorthwindContext())
    {
        foreach (var customer in northwindContext.Customers)
        {
            Console.WriteLine("Customer Name : {0}", customer.ContactName);
        }
    }
}
Console.ReadLine();
