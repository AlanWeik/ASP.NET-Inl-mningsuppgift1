using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Inlämningsuppgift1.Data;
using ASP.NET_Inlämningsuppgift1.Models;

namespace ASP.NET_Inlämningsuppgift1.Pages
{
    public class MyEventsModel : PageModel
    {
        private readonly ASP.NET_Inlämningsuppgift1.Data.EventDbContext _context;

        public MyEventsModel(ASP.NET_Inlämningsuppgift1.Data.EventDbContext context)
        {
            _context = context;
        }
        public Attendee Attendee { get; set; }
        public async Task OnGetAsync()
        {
            Attendee = await _context.Attendees.Where(a => a.Id == 1)
                .Include(e => e.Events)
                .FirstOrDefaultAsync();
        }
    }
}