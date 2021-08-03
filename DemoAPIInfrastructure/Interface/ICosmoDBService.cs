using DemoAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPIInfrastructure.Interface
{
    public interface ICosmoDBService
    {
        Task<IEnumerable<ToDo>> GetMultipleAsync(string query);
        Task<ToDo> GetAsync(string id);
        Task AddAsync(ToDo item);
        Task UpdateAsync(string id, ToDo item);
        Task DeleteAsync(string id);
    }
}
