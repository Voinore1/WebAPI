using Core.Models;

namespace Core.Interfaces
{
    public interface IAccountService
    {
        Task Register(RegisterModel model);
    }

}
