using ItemStore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItemStore.Infrastructure
{
    public class ItemDbContext:DbContext
    {
           public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
    }
}
