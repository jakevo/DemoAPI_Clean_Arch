using DemoAPIDomain.Interfaces;
using DemoAPIDomain.Models;
using DemoAPIInfrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAPIInfrastructure.Repository
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly ICosmoDBService _cosmoDBService;

        public ToDoRepository(ICosmoDBService cosmoDBService)
        {
            _cosmoDBService = cosmoDBService;
        }
        public IEnumerable<ToDo> GetAllToDoItem()
        {
            throw new NotImplementedException();
        }
    }
}
