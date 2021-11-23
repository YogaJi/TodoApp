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
    public class CreateModel : PageModel
    {
        private readonly TodoApp.Data.TodoContext _context;

        public CreateModel(TodoApp.Data.TodoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Todo Todo { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Todos.Add(Todo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
/*        public async Task<IActionResult> OnGetAsync()
        {
   
            ViewData["TodoItems"] = new SelectList(_context.Catergory, "CatergoryId", "CatergoryName");
            return Page();
        }*/
    }
}
