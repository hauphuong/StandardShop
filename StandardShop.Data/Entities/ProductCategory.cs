﻿using StandardShop.Data.Enums;
using StandardShop.Data.Interfaces;
using StandardShop.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StandardShop.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>(); 
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int SortOrder { get; set; }
        public virtual ICollection<Product> Products { set; get; }
    }
}