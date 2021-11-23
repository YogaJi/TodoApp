using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Catergory> Catergory { get; set; }


        /*        protected override void OnConfiguring(DbContextOptionsBuilder builder)
                {
                    builder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TodoList;Integrated Security=true;");
                }*/
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {

        }
    }
}
