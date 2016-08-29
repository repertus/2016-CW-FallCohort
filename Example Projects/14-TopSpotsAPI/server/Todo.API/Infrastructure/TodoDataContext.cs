using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Todo.API.Infrastructure
{
    public class TodoDataContext : DbContext
    {
        public TodoDataContext() : base("Todo")
        {

        }

        public IDbSet<Todo.API.Models.Todo> Todoes { get; set; }
    }
}