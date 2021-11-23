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
    public class DetailsModel : PageModel
    {
        private readonly TodoApp.Data.TodoContext _context;

        public DetailsModel(TodoApp.Data.TodoContext context)
        {
            _context = context;
        }

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
    }
}
