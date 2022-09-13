﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIDemo.Models;

namespace APIDemo.Data
{
    public class APIDemoContext : DbContext
    {
        public APIDemoContext (DbContextOptions<APIDemoContext> options)
            : base(options)
        {
        }

        public DbSet<APIDemo.Models.Pizza> Pizza { get; set; } = default!;

        public DbSet<APIDemo.Models.Ticket>? Ticket { get; set; }

        public DbSet<APIDemo.Models.User>? User { get; set; }
    }
}