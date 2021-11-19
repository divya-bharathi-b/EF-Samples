using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyWebApp01.Data;
using MyWebApp01.Models;

namespace MyWebApp01.Pages.Data
{
    public class CreateModel : PageModel
    {
        private readonly MyWebApp01.Data.MyWebApp01Context _context;

        public CreateModel(MyWebApp01.Data.MyWebApp01Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Timesheet Timesheet { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Timesheet.Add(Timesheet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
