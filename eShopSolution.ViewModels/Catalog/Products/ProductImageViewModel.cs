﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductImageViewModel
    {
        public int Id { get; set; }
        public String FilePath { get; set; }
        public bool isDefault { get; set; }
        public long FileSize { get; set; }
        
    }
}
