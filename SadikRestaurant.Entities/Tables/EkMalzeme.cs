using SadikRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadikRestaurant.Entities.Tables
{
   public class EkMalzeme:EntityBase
    {
        public string EkMalzemeAdi { get; set; }
        public decimal Fiyat { get; set; }
        public Guid UrunId { get; set; }
        public virtual urun Urun { get; set; }
        
    }
}
