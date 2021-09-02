﻿using Microsoft.AspNetCore.Identity;
using System;

namespace Armazem.Models
{
    public class Product
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime? created { get; set; }
        public DateTime? updated { get; set; }
        public string updatedById { get; set; }
        public IdentityUser updatedBy { get; set; }
        public string createdById { get; set; }
        public IdentityUser createdBy { get; set; }
    }
}
