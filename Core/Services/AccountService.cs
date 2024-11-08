using AutoMapper;
using Core.Exceptions;
using Core.Interfaces;
using Core.Models;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Net;

namespace Core.Services
{
    public class AccountService(IMapper mapper,
                                UserManager<User> userManager,
                                SignInManager<User> signInManager) : IAccountService
    {
        public async Task Register(RegisterModel model)
        {
            var user = mapper.Map<User>(model);

            var result = await userManager.CreateAsync(user, model.Password);
            var res = result.Errors.First();


            if (!result.Succeeded) throw new HttpException(res.Description, HttpStatusCode.BadRequest);
        }

        public async Task Login(LoginModel model)
        {

            var user = await userManager.FindByEmailAsync(model.Username);

            user ??= await userManager.FindByNameAsync(model.Username);

            if (user == null || !await userManager.CheckPasswordAsync(user, model.Password))
            {
                throw new HttpException("Invalid login or password", HttpStatusCode.NotFound);
            }   

            await signInManager.SignInAsync(user, true);


        }

        public async Task Logout()
        {
            await signInManager.SignOutAsync();
        }
    }
}
