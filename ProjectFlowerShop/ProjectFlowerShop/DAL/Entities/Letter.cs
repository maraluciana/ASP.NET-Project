﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.DAL.Entities
{
    public class Letter
    {
        [ForeignKey("ShoppingCart")]
        public Guid Id { get; set; }
        public string Message { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}