using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Context
{
    public class ShoppingCartContext : IdentityDbContext
    {

        //requirement: ensure that we the right connection string setup in place

        //add-migration <name> ShoppingCartContext
        //update-database
        public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; } //an abstraction of the tables therefore plural name
        public DbSet<Category> Categories { get; set; }
    }
}
