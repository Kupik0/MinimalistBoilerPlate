using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.Dto;
using WebApi.Models;
using WebApi.Services.Abstract;

namespace WebApi.Services.Concrete
{
    public class UserService : IUserService
    {
        protected DbSet<User> user => dbContext.Set<User>();

        private readonly KaderKutusuDbContext dbContext;
        private readonly IMapper mapper;
        public UserService(KaderKutusuDbContext dbContext , IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<List<UserDto>> GetAll()
        {
            var users = await user.ToListAsync();
            var viewModel = mapper.Map<List<UserDto>>(users);
            return viewModel;

        }
        public async Task<UserToken> UserLogin(UserLogin user)
        {

    
            var arananuser = dbContext.User.Where(i => i.EPosta == user.Eposta);

            

            //string password = dbContext.User.Where(i => i.Sifre == user.Sifre);
            if (arananuser.FirstOrDefault() is null)
                throw new Exception("kullanıcı bulunamadı");
            if (arananuser.FirstOrDefault().Sifre != user.Sifre)
                throw new Exception("şifre yanlış");

            UserToken token = new UserToken();
            return token;


        }
    }
}
