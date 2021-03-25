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

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Events.ToListAsync();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("./Index");
        }  
    }
}
