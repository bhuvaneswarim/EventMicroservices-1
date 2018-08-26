﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Models.CartModels
{
    public class Cart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public string BuyerId { get; set; }

        public decimal Total()
        {
            return Math.Round(Items.Sum(x => x.Price * x.Quantity), 2);
        }

    }
}
