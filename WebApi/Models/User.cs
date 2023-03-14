
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class User : BaseEntity
    {
        
        public string AdSoyad { get; set; }
        public string Yas { get; set; }
        public string EPosta { get; set; }
        public string Adres { get; set; }
        public string Sifre { get; set; }
        //public int SepetId { get; set; }
        //public Sepet? Sepet { get; set; }
    }
}
