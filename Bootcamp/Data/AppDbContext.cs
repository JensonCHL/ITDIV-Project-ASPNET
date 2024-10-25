using System;
using Bootcamp.Models;
using Microsoft.EntityFrameworkCore;

namespace Bootcamp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<LtPayment> LtPayment { get; set; }
    public DbSet<MsCar> MsCar { get; set; }
    public DbSet<MsCarImages> MsCarImages { get; set; }
    public DbSet<MsCustomer> MsCustomer { get; set; }
    public DbSet<MsEmployee> MsEmployee { get; set; }
    public DbSet<TrMaintenance> TrMaintenance { get; set; }
    public DbSet<TrRental> TrRental { get; set; }

}
