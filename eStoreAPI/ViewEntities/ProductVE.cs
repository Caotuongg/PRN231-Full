﻿using Repositories.Entities;

namespace eStoreAPI.ViewEntities
{
    public class ProductVE
    {
        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Weight { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        
    }
}
