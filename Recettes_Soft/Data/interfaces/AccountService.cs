using Recettes_Soft.Data.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data.interfaces
{
    public interface IAccountService
    {
        Task Initialize();
        Task Login(Login model);
        Task Logout();
    }
    public class AccountService : IAccountService
    {
        //private IHttpService _httpService;
        //private NavigationManager _navigationManager;
        //private ILocalStorageService _localStorageService;
        private string _userKey = "user";
        public Task Initialize()
        {
            throw new NotImplementedException();
        }

        public Task Login(Login model)
        {
            throw new NotImplementedException();
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }
    }
}
