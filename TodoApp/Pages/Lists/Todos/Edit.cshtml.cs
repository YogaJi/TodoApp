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
    public class EditModel : PageModel
    {
        private readonly TodoApp.Data.TodoContext _context;
        private readonly TodoContext db;
        public EditModel(TodoApp.Data.TodoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Todo Todo { get; set; }
        public Catergory Catergory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Todo = await _context.Todos.Include(p => p.Catergories).FirstOrDefaultAsync(m => m.TodoId == id);
            //include catergories to the todo
            if (Todo == null)
            {
                return NotFound();
            }
            ViewData["TodoItems"] = new SelectList(_context.Catergory, "CatergoryId", "CatergoryName");
            //set viewData with selectList of catergoryName
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                db.Todos.Add(Todo);
                return Page();
            }

            _context.Attach(Todo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoExists(Todo.TodoId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TodoExists(int id)
        {
            return _context.Todos.Any(e => e.TodoId == id);
        }
    }
}
