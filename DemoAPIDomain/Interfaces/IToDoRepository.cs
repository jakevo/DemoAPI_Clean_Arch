using DemoAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAPIDomain.Interfaces
{
    public interface IToDoRepository
    {
        IEnumerable<ToDo> GetAllToDoItem(); 
    }
}
