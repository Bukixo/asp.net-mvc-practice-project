﻿using DutchTreat.Data.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Data
{
    public class DutchRepository : IDutchRepository
    {
        private readonly DutchContext _context;
        private readonly ILogger<DutchRepository> _logger;

        public DutchRepository(DutchContext context, ILogger<DutchRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            _logger.LogInformation("GetAllProducts was called");
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
