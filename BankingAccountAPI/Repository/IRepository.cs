using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAccountAPI.Repository
{
    interface IRepository<T>
    {
        Task<T> Get();
        Task<List<T>> GetAllById();
        Task<T> Save(T t);
        Task<List<T>> SaveAll(List<T> listt);
        Task<T> Delete(T t);
        Task<List<T>> DeleteAll(List<T> listt);
    }
}
