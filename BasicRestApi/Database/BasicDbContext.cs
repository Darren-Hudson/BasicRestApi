using System;
using BasicRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicRestApi.Database
{
    public class BasicDbContext : DbContext
    {
        public BasicDbContext(DbContextOptions<BasicDbContext> options): base(options){}
        public DbSet<Note> Notes { get; set; }
    }
}
