using SadikRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadikRestaurant.DataAccess.Mappings
{
   public class EkMalzemeMap:EntityTypeConfiguration<EkMalzeme>
    {
        public EkMalzemeMap()
        {
            
            Property(c => c.EkMalzemeAdi).HasMaxLength(50);
            Property(c => c.Fiyat).HasPrecision(10, 2);
            ToTable("EkMalzemeler");
            Property(c => c.EkMalzemeAdi).HasColumnName("EkMalzemeAdi");
            Property(c => c.Fiyat).HasColumnName("Fiyat");
            Property(c => c.UrunId).HasColumnName("UrunId");
        }
    }
}
