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
        public UserService(KaderKutusuDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<User>> GetAll()
        {
            var users = await user.ToListAsync();
         
            return users;

        }

    }
}
