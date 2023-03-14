using System.Threading.Tasks;
using WebApi.Dto;
using WebApi.Models;

namespace WebApi.Services.Abstract
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAll();
        Task<UserToken> UserLogin(UserLogin user);
    }

}
