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
    public class IndexModel : PageModel
    {
        private readonly MyWebApp01.Data.MyWebApp01Context _context;

        public IndexModel(MyWebApp01.Data.MyWebApp01Context context)
        {
            _context = context;
        }

        public IList<Timesheet> Timesheet { get;set; }

        public async Task OnGetAsync()
        {
            Timesheet = await _context.Timesheet.ToListAsync();
        }
    }
}
