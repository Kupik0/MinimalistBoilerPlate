using WebApi.Dto;
using WebApi.Models;

namespace WebApi.Services.Abstract
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
    }
}
