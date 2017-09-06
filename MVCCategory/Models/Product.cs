﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCategory.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}