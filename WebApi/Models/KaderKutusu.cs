using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class KaderKutusu : BaseEntity
    {
        public int SepetId { get; set; }
        public Sepet Sepet { get; set; }
        public DogalTas KaderTas { get; set; }

    }
}
