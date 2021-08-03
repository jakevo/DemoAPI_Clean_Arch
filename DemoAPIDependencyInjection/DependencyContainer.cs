using DemoAPIApplication.Interfaces;
using DemoAPIApplication.Services;
using DemoAPIDomain.Interfaces;
using DemoAPIInfrastructure.Interface;
using DemoAPIInfrastructure.Repository;
using DemoAPIInfrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPIDependencyInjection
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            //application
            services.AddScoped<IToDoService, ToDoService>();
            //Infractructure
            services.AddScoped<IToDoRepository, ToDoRepository>();
            services.AddSingleton<ICosmoDBService>(InitializeCosmosClientInstanceAsync(configuration.GetSection("CosmosDb")).GetAwaiter().GetResult());
        }

        private static async Task<ICosmoDBService> InitializeCosmosClientInstanceAsync(IConfigurationSection configurationSection)
        {
            var databaseName = configurationSection["DatabaseName"];
            var containerName = configurationSection["ContainerName"];
            var account = configurationSection["Account"];
            var key = configurationSection["Key"];
            var client = new Microsoft.Azure.Cosmos.CosmosClient(account, key);
            var database = await client.CreateDatabaseIfNotExistsAsync(databaseName);
            await database.Database.CreateContainerIfNotExistsAsync(containerName, "/id");
            var cosmosDbService = new CosmoDBService(client, databaseName, containerName);
            return cosmosDbService;
        }

    }
}
