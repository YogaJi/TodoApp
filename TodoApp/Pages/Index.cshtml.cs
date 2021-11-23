using TodoApp.Data;
using TodoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly TodoContext db;

        [FromForm]

        public Todo Todo { get; set; }
        public List<Todo> TodoList { get; set; }
        public IndexModel(ILogger<IndexModel> logger, TodoContext dbConttext)
        {
            _logger = logger;
            db = dbConttext;
        }

        public void OnGet()
        {
            TodoList = db.Todos.ToList();
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Todos.Add(Todo);
                db.SaveChanges();
            }
        }
    }
}
