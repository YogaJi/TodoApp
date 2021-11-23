using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Pages.Lists.Catergories
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
        public Catergory Catergory { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Catergory.Add(Catergory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
