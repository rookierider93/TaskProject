using System;
using Microsoft.EntityFrameworkCore;
using TaskDemo.Models;

namespace TaskDemo.Data;

public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
{
    public DbSet<User> users { get; set; }
    public DbSet<Tasks> tasks { get; set; }
}
