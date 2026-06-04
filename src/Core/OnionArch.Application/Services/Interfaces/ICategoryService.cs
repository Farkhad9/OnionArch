using OnionArch.Application.Dtos.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArch.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryReturnDto>> GetAllCategoriesAsync();
        Task CreateCategoryAsync(CategoryCreateDto categoryCreateDto);
    }
}
