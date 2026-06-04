using Microsoft.EntityFrameworkCore;
using OnionArch.Application.Dtos.Category;
using OnionArch.Application.Interfaces;
using OnionArch.Application.Services.Interfaces;
using OnionArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArch.Application.Services.Concretes
{
    public class CategoryService(IApplicationDbContext dbContext) : ICategoryService
    {
        public async Task CreateCategoryAsync(CategoryCreateDto categoryCreateDto)
        {
          var category = new Category
          {
              Name = categoryCreateDto.Name
          };
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<CategoryReturnDto>> GetAllCategoriesAsync()
        {
            var categories = await dbContext.Categories
                .Select(c => new CategoryReturnDto(c.Id, c.Name))
                .ToListAsync();

            return categories;
        }
    }
}
