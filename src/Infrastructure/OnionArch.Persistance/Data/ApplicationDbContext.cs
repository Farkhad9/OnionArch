using Microsoft.EntityFrameworkCore;
using OnionArch.Application.Interfaces;
using OnionArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArch.Persistance.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
