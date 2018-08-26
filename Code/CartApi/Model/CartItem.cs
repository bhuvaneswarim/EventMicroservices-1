﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesOnContainers.Services.CartApi.Model
{
    public class CartItem
    {
        public int OrderId { get; set; }

        public int TicketTypeId { get; set; }

        public string TypeName { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public int EventId { get; set; }

        public string ImageUrl { get; set; }
    }
}
