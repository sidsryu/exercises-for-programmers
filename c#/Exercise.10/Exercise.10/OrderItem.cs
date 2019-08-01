﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._10
{
    public struct OrderItem
    {
        public double Price { get; set; }
        public int Count { get; set; }

        public OrderItem(double price, int count)
        {
            this.Price = price;
            this.Count = count;
        }
    }
}
