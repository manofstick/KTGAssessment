﻿using System;
namespace KTG.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Order() { }
    }
}
