using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Pages.Lists.Todos
{
    public class DetailsModel : PageModel
    {
        private readonly TodoApp.Data.TodoContext _context;

        public DetailsModel(TodoApp.Data.TodoContext context)
        {
            _context = context;
        }

        public Todo Todo { get; set; }
        public Catergory Catergory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Todo = await _context.Todos.Include(p => p.Catergories).FirstOrDefaultAsync(m => m.TodoId == id);

            if (Todo == null)
            {
                return NotFound();
            }
            
            return Page();
        }
    }
}
