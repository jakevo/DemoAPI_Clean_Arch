using DemoAPIDomain.Models;
using DemoAPIInfrastructure.Interface;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPIInfrastructure.Services
{
    public class CosmoDBService: ICosmoDBService
    {
        private Container _container;
        public CosmoDBService(
            CosmosClient cosmosDbClient,
            string databaseName,
            string containerName)
        {
            _container = cosmosDbClient.GetContainer(databaseName, containerName);
        }

        public Task AddAsync(ToDo item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ToDo> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToDo>> GetMultipleAsync(string query)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, ToDo item)
        {
            throw new NotImplementedException();
        }
    }
}
