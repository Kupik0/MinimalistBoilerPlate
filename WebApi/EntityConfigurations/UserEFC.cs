using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;

namespace WebApi.EntityConfigurations
{
    public class UserEFC : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(c => c.Id);
            builder.ToTable("User", "KaderKutusu");
            builder.HasData
                (
                new User { Id = 1,  AdSoyad = " Selda Bağcan" , Adres ="Konak mah. 312. Cd. 123. sk İzmir Türkiye", EPosta = "vurucusesselda@yahoo.com",  Sifre = "123456", Yas = "64"}
                );
        }
    }
}
