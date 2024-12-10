using Core.Models;

namespace Core.Interfaces
{
    public interface IAccountService
    {
        Task<LoginResponce> Register(RegisterModel model);
        Task<LoginResponce> Login(LoginModel model);
        Task Logout();
    }

}
