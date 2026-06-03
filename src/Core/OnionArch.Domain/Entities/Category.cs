using OnionArch.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArch.Domain.Entities
{
    public class Category: BaseEntity
    {
        public string Name { get; set; } = null!;
        public List<Product> Products { get; set; } = [];
    }
}
