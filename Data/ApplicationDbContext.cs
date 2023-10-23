﻿using Fitness_Tracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;

namespace Fitness_Tracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Body> Body { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Macro> Macros { get; set; }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<User> User { get; set; }

    }
}
