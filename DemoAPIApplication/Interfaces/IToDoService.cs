using DemoAPIApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAPIApplication.Interfaces
{
    public interface IToDoService
    {
        ToDoViewModel GetAllToDoItem();
    }
}
