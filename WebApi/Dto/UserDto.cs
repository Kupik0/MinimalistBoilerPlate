using WebApi.Models;

namespace WebApi.Dto
{
    public class UserDto
    {
        public string AdSoyad { get; set; }
        public string Yas { get; set; }
        public string EPosta { get; set; }
        public string Adres { get; set; }
        public int SepetId { get; set; }
        public Sepet? Sepet { get; set; }
    }
}
