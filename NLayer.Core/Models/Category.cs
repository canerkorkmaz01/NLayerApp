﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        //Navigasiyon property denir
        public ICollection<Product> Products { get; set; }
    }
}