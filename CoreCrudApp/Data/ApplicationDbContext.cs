﻿using CoreCrudApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreCrudApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
