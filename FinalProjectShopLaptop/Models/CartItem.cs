﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectShopLaptop.Models
{ 
    [Serializable]
    public class CartItem
    {
        public SanPham SanPham { get; set; }
        public int Quantity { get; set; }
    }
}