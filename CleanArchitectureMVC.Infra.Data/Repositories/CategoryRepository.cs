using CleanArchitectureMVC.Domain.Entities;
using CleanArchitectureMVC.Domain.Interfaces;
using CleanArchitectureMVC.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitectureMVC.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CategoryRepository(ApplicationDbContext context)
        {
            _applicationDbContext = context;
        }

        public async Task<Category> GetByIdAsync(int? id)
        {
            return await _applicationDbContext.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _applicationDbContext.Categories.ToListAsync();
        }

        public async Task<Category> CreateAsync(Category category)
        {
            _applicationDbContext.Add(category);
            await _applicationDbContext.SaveChangesAsync();

            return category;
        }

        public async Task<Category> RemoveAsync(Category category)
        {
            _applicationDbContext.Remove(category);
            await _applicationDbContext.SaveChangesAsync();

            return category;
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            _applicationDbContext.Update(category);
            await _applicationDbContext.SaveChangesAsync();

            return category;
        }
    }
}
