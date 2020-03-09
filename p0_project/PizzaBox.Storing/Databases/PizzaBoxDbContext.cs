using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;

namespace PizzaBox.Storing.Databases
{
  //dbcontext is the reprsentation of the 
  public class PizzaBoxDbContext: DbContext
  {
    //What did that command do?
    //creating a table called pizzas
    public DbSet<Pizza> Pizzas { get; set;}
    public DbSet<Size> Sizes{ get; set;}
    public DbSet<Crust> Crusts{get;set ;}
    public DbSet<Topping> Toppings { get;set;}
    public DbSet<Order> Orders { get; set;} // created an entity set of Order for CRUD operations

  //This is the connection to the database
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;database=pizzaboxdb;user id=sa;password=Password12345");
    }
  //Pizza object to become sql object
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(c => c.CrustId);
      builder.Entity<Size>().HasKey(s => s.SizeId);
      builder.Entity<Pizza>().HasKey(p => p.PizzaId);
      builder.Entity<PizzaTopping>().HasKey(pt => new { pt.PizzaId, pt.ToppingId });
      builder.Entity<Topping>().HasKey(t => t.ToppingId);
      builder.Entity<Order>().HasKey(o => o.OrderId);
      builder.Entity<OrderPizza>().HasKey(op => new { op.OrderId, op.PizzaId });
  
      // builder.Entity<Size>().HasMany
      //giving predefinded data to database 
      builder.Entity<Crust>().HasMany(c => c.Pizzas).WithOne(p => p.Crust);
      builder.Entity<Pizza>().HasMany(p => p.PizzaToppings).WithOne(pt => pt.Pizza).HasForeignKey(pt => pt.PizzaId);
      builder.Entity<Size>().HasMany(s => s.Pizzas).WithOne(p => p.Size);
      builder.Entity<Topping>().HasMany(t => t.PizzaToppings).WithOne(pt => pt.Topping).HasForeignKey(pt => pt.ToppingId);
      builder.Entity<Order>().HasMany(o => o.OrderPizzas).WithOne(op => op.order).HasForeignKey(op => op.PizzaId);
  
      builder.Entity<Size>().HasData(new Size[] 
      {
        new Size() { Name = "Large", Price = 12.0M},
        new Size() { Name = "Medium", Price = 10.0M },
        new Size() { Name = "Small", Price = 8.00M}
      });

      builder.Entity<Crust>().HasData(new Crust[]
      {
        new Crust() { Name = "Deep Dish" , Price = 4.00M },
        new Crust() { Name = "New york style" , Price =3.00M },
        new Crust() { Name = "Thin Crust", Price =1.50M }
      });

      builder.Entity<Topping>().HasData(new Topping[]
      {      
        new Topping() { Name = "Cheese", Price = 0.25M },
        new Topping() { Name = "Pepperoni", Price = 0.50M },
        new Topping() { Name = "Tomato Sauce" , Price = 0.75M},
      });
      
    }
  }
}