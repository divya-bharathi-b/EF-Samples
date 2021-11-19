using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWebApp01.Data;
using MyWebApp01.Models;

namespace MyWebApp01.Pages.Data
{
    public class EditModel : PageModel
    {
        private readonly MyWebApp01.Data.MyWebApp01Context _context;

        public EditModel(MyWebApp01.Data.MyWebApp01Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Timesheet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimesheetExists(Timesheet.id))
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

        private bool TimesheetExists(int id)
        {
            return _context.Timesheet.Any(e => e.id == id);
        }
    }
}
