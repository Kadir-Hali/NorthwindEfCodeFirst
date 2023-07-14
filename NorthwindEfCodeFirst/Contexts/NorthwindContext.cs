using System.Data.Entity;
using NorthwindEfCodeFirst.Entities;

namespace NorthwindEfCodeFirst.Contexts;

public class NorthwindContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
}