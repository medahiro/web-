﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class TodoesContext : DbContext
    {
        public DbSet<Todo> Todoes { get; set; }
    }

}