﻿using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Genre> Genres { get; set; }
  }
}
