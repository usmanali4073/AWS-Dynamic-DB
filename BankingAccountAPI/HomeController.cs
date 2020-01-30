using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingAccountAPI.Models;
using BankingAccountAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingAccountAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private AccountRepositor _accountRepositor;
        public HomeController(AccountRepositor accountRepositor)
        {
            _accountRepositor = accountRepositor;
        }
        // GET: api/Home
        [HttpGet]
        public async Task<IEnumerable<string>> Gets()
        {
            AccountModel accountModel = new AccountModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Usman Ali",
                Total = 20,
                Commnets = "this Test",
                addressModels = new List<AddressModel>()
                {
                    new AddressModel()
                    {
                        Id = Guid.NewGuid().ToString(),
                        StreetName = "142 Terrace Drive",
                        State = "CT",
                        TownName  = "Vernon"
                    }
                }
            };

            await _accountRepositor.Save(accountModel);

            return new string[] { "value1", "value2" };
        }
    }
}
