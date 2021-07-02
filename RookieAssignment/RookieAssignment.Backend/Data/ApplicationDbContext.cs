using Microsoft.EntityFrameworkCore;
using RookieAssignment.Backend.Data.Migrations;
using RookieAssignment.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<MenuItemComment> MenuItemComment { get; set; }
    }
}
