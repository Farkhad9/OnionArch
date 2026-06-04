using Microsoft.EntityFrameworkCore;
using OnionArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArch.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Category> Categories { get; set; }
        Task<int> SaveChangesAsync();
    }
}
