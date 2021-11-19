using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebApp01.Data;
using MyWebApp01.Models;

namespace MyWebApp01.Pages.Data
{
    public class DeleteModel : PageModel
    {
        private readonly MyWebApp01.Data.MyWebApp01Context _context;

        public DeleteModel(MyWebApp01.Data.MyWebApp01Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Timesheet Timesheet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Timesheet = await _context.Timesheet.FirstOrDefaultAsync(m => m.id == id);

            if (Timesheet == null)
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

            Timesheet = await _context.Timesheet.FindAsync(id);

            if (Timesheet != null)
            {
                _context.Timesheet.Remove(Timesheet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
