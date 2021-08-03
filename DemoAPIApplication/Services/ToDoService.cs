using DemoAPIApplication.Interfaces;
using DemoAPIApplication.ViewModels;
using DemoAPIDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAPIApplication.Services
{
    //checkin
    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }
        public ToDoViewModel GetAllToDoItem()
        {
            return new ToDoViewModel()
            {
                Todos = _toDoRepository.GetAllToDoItem()
            };
        }
    }
}

