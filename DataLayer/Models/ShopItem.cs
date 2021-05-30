using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class ShopItem
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSize { get; set; }
        public decimal ProductPrice { get; set; }
        public bool? ProductDiscount { get; set; }
    }
}
