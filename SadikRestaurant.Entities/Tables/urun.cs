﻿using SadikRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadikRestaurant.Entities.Tables
{
   public class urun:EntityBase
    {
        public string Barkod { get; set; }
        public string Adi { get; set; }
        public byte[] Fotograf { get; set; }
        public ICollection<EkMalzeme> EkMalzemeler { get; set; }
        public Guid UrunGrupId { get; set; }
        public virtual Tanim UrunGrup { get; set; }
        public ICollection<Porsiyon> Porsiyonlar { get; set; }
    }
}
