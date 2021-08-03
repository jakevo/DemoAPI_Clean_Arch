using DemoAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAPIApplication.ViewModels
{
    public class ToDoViewModel
    {
        public IEnumerable<ToDo> Todos { set; get; }
    }
}
