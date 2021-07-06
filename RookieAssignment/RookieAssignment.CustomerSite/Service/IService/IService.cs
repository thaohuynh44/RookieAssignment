using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.CustomerSite.Service
{
    public interface IService<T> where T : class
    {
        Task<T> GetAsync(string url, int Id);
        Task<IEnumerable<T>> GetAllAsync(string url);
        Task<IEnumerable<T>> GetAllAsyncByParentId(string url, int id);
        Task<bool> CreateAsync(string url, T objToCreate);
    }
}
