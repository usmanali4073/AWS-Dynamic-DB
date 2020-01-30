using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Runtime;
using BankingAccountAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAccountAPI.Repository
{
    public class AccountRepositor
    {
        private readonly IDynamoDBContext _dBContext;
        public AccountRepositor(IDynamoDBContext dBContext)
        {
            _dBContext = dBContext;
            
        }
        public Task<AccountModel> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<AccountModel>> GetAllById()
        {
            throw new NotImplementedException();
        }

        public async Task Save(AccountModel t)
        {
           await _dBContext.SaveAsync(t);

        }

        public Task<List<AccountModel>> SaveAll(List<AccountModel> listt)
        {
            throw new NotImplementedException();
        }

        public Task<AccountModel> Delete(AccountModel t)
        {
            throw new NotImplementedException();
        }

        public Task<List<AccountModel>> DeleteAll(List<AccountModel> listt)
        {
            throw new NotImplementedException();
        }
    }
}
