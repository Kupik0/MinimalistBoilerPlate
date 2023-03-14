using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class DogalTas : BaseEntity
    {
        public string Isim { get; set; }
        public string Ozellikler { get; set; }
        public decimal Maliyet { get; set; }
        public decimal OrtalamaAgirlik { get; set; }
        public int Stok { get; set; }
        public IEnumerable<Kutu> BulunduguKutular { get; set; }
    }
}
