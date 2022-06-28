﻿using ElevenNoteWebApp.Shared.Models.Category;

namespace ElevenNoteWebApp.Server.Services.Category
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryListItem>> GetAllCategoriesAsync();
        Task<bool> CreateCategoryAsync(CategoryCreate model);
        Task<CategoryDetail> GetCategoryByIdAsync(int cateogryId);
        Task<bool> UpdateCategoryAsync(CategoryEdit model);
        Task<bool> DeleteCategoryAsync(int categoryId);
    }
}
