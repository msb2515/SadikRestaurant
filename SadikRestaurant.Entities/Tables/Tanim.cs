using SadikRestaurant.Entities.Enums;
using SadikRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadikRestaurant.Entities.Tables
{
    public class Tanim : EntityBase
    {
        public string Adi { get; set; }
        public TanimTip TanimTip { get; set; }


    }
}
