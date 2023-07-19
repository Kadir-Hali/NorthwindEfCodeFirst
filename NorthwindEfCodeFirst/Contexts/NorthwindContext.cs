using NorthwindEfCodeFirst.Entities;
using System.Data.Entity;

namespace NorthwindEfCodeFirst.Contexts;

public class NorthwindContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
}