using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Kutu : BaseEntity
    {
        public string Tur { get; set; }

        public string UrunKodu { get; set; }
        public decimal Fiyat { get; set; }
        public IEnumerable<DogalTas> Icerik { get; set; }

    }
}
