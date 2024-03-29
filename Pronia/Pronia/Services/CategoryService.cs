﻿using Microsoft.EntityFrameworkCore;
using Pronia.Data;
using Pronia.Models;
using Pronia.Services.Interfaces;

namespace Pronia.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetCategories() => await _context.Categories.Include(m => m.ProductCategories).Where(m => !m.SoftDelete).ToListAsync();
        

        public async Task<Category> GetByIdAsync(int? id) => await _context.Categories.Include(m => m.ProductCategories).Where(m => !m.SoftDelete).FirstOrDefaultAsync(m => m.Id == id);
    }
}
