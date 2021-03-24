using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Inlämningsuppgift1.Models;

namespace ASP.NET_Inlämningsuppgift1.Data
{
    public class DbInitializer
    {
        public static void Initialize(EventDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Events.Any())
            {
                return;   // DB has been seeded
            }
            var attendees = new Attendee[]
            {
                new Attendee { Name="Albert Krimson", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},
                new Attendee { Name="Svante Pålsson", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},
                new Attendee { Name="Svante Pålsson", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},
                new Attendee { Name="Tom Nordbeck", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},
                new Attendee { Name="Lana Lane", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},
                new Attendee { Name="Alan Weik", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},
                new Attendee { Name="Civil Polis", Phone_Number=0793123456, Email="SomeEmail@gmail.com"},

            };
            context.Attendees.AddRange(attendees);
            context.SaveChanges();

            var events = new Event[]
            {
                new Event { Place="Stockholm Stadion", Date=14/7-2021, Description="The Doors, live concert", Spots_Available=200},
                new Event { Place="02 Arena", Date=14/7-2021, Description="Khruangbin, live concert", Spots_Available=0},
                new Event { Place="Etihad Stadium", Date=14/7-2021, Description="Tame Impala, live concert", Spots_Available=20},
                new Event { Place="Camp Nou", Date=14/7-2021, Description="Soccer match, Barcelona FC vs Real Madrid FC", Spots_Available=2000},
            };
            context.Events.AddRange(events);
            context.SaveChanges();

            var organizers = new Organizer[]
            {
                new Organizer{ Name="Real Records", Phone_Number=043123156, Email="OurEmail@gmail.com" },
                new Organizer{ Name="Thai Events", Phone_Number=043122456, Email="OurEmail@gmail.com" },
                new Organizer{ Name="Groovy Records", Phone_Number=043123456, Email="OurEmail@gmail.com" },
                new Organizer{ Name="Tickermaster", Phone_Number=043123454, Email="OurEmail@gmail.com" },
            };
            context.Organizers.AddRange(organizers);
            context.SaveChanges();

        }
    }
}
