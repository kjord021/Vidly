﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Vidly.Models
{
    public class VidlyDBContext : DbContext
    {
        public VidlyDBContext()
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}