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
    public class ShowEventsModel : PageModel
    {
        private readonly ASP.NET_Inlämningsuppgift1.Data.EventDbContext _context;

        public ShowEventsModel(ASP.NET_Inlämningsuppgift1.Data.EventDbContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Events.Include(@event => @event.Organizer).ToListAsync();
        }
    }
}
