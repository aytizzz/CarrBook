﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarFeature
    {
        [Key]
        public int FeatureID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int FeatureeID { get; set; }
        public Feature Feature { get; set; }
        public bool Available { get; set; }
    }
}
