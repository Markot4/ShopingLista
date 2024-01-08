using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shopinglista.Models;

    public class shopinglistaContext : DbContext
    {
        public shopinglistaContext (DbContextOptions<shopinglistaContext> options)
            : base(options)
        {
        }

        public DbSet<shopinglista.Models.ShoppingItem> ShoppingItem { get; set; } = default!;
    }
