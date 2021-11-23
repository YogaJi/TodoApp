using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Pages.Lists.Catergories
{
    public class DeleteModel : PageModel
    {
        private readonly TodoApp.Data.TodoContext _context;

        public DeleteModel(TodoApp.Data.TodoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Catergory Catergory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Catergory = await _context.Catergory.FirstOrDefaultAsync(m => m.CatergoryId == id);

            if (Catergory == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Catergory = await _context.Catergory.FindAsync(id);

            if (Catergory != null)
            {
                _context.Catergory.Remove(Catergory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
