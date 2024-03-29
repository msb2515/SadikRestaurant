﻿using SadikRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadikRestaurant.Entities.Tables
{
    public class Porsiyon : EntityBase
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public decimal EkMalzemeCarpan { get; set; }
        public Guid UrunId { get; set; }
        public virtual urun Urun { get; set; }
        public Guid BirimId { get; set; }
        public virtual Tanim Birim { get; set; }
    }
}
