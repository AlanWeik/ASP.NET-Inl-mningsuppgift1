using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Inlämningsuppgift1.Models;

namespace ASP.NET_Inlämningsuppgift1.Data
{
    public class EventDbContext : DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Attendee> Attendees { get; set; }
        public DbSet<Models.Event> Events { get; set; }
        public DbSet<Models.Organizer> Organizers { get; set; }

    }
}

/*public void Seed()
{
    this.Attendees.RemoveRange(this.Attendees);
    this.Events.RemoveRange(this.Events);
    this.Organizers.RemoveRange(this.Organizers);

    this.Attendees.AddRange(new List<Models.Attendee>() {
            new Models.Attendee(){ Name="Albert Krimson", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},
            new Models.Attendee(){ Name="Svante Pålsson", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},
            new Models.Attendee(){ Name="Tom Nordbeck", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},
            new Models.Attendee(){ Name="Lana Lane", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},
            new Models.Attendee(){ Name="Alan Weik", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},
            new Models.Attendee(){ Name="Civil Polis", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},

        });

    this.Events.AddRange(new List<Models.Event>() {
            new Models.Event(){  Place="Stockholm Stadion", Date=14/7-2021, Description="The Doors, live concert", Spots_Available=200},
            new Models.Event(){  Place="02 Arena", Date=14/7-2021, Description="Khruangbin, live concert", Spots_Available=0},
            new Models.Event(){  Place="Etihad Stadium", Date=14/7-2021, Description="Tame Impala, live concert", Spots_Available=20},
            new Models.Event(){  Place="Camp Nou", Date=14/7-2021, Description="Soccer match, Barcelona FC vs Real Madrid FC", Spots_Available=2000},
        });

    this.Organizers.AddRange(new List<Models.Organizer>()
    {
            new Models.Organizer(){ Name="Real Records", Phone_Number=043123156, Email="OurEmail@gmail.com" },
            new Models.Organizer(){ Name="Thai Events", Phone_Number=043122456, Email="OurEmail@gmail.com" },
            new Models.Organizer(){ Name="Groovy Records", Phone_Number=043123456, Email="OurEmail@gmail.com" },
            new Models.Organizer(){ Name="Tickermaster", Phone_Number=043123454, Email="OurEmail@gmail.com" },

    });

    this.SaveChanges();
}
}
}*/
