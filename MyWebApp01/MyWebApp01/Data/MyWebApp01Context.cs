using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebApp01.Models;

namespace MyWebApp01.Data
{
    public class MyWebApp01Context : DbContext
    {
        public MyWebApp01Context (DbContextOptions<MyWebApp01Context> options)
            : base(options)
        {
        }

        public DbSet<MyWebApp01.Models.Timesheet> Timesheet { get; set; }
    }
}
