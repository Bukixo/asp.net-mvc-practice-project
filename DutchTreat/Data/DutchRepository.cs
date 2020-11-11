﻿using DutchTreat.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Data
{
    public class DutchRepository : IDutchRepository
    {
        private DutchContext _context;

        public DutchRepository(DutchContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products
                        .OrderBy(product => product.Title)
                        .ToList();
        }

        public IEnumerable<Product> GetProductsByCategories(string category)
        {
            return _context.Products
                .Where(product => product.Category == category)
                .ToList();
        }

        public bool SaveChanges()
        {
           return _context.SaveChanges() > 0;
        }
    }
}