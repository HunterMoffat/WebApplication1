﻿using WebApplication1.Models;
using System;
using System.Linq;

namespace WebApplication1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(URC_Context context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Opportunity.Any())
            {
                return;   // DB has been seeded
            }
            
            var opportunities = new Opportunity[]
            {
               
                new Opportunity{Name = "5G Testbed Research", Description="Help us research new ways to communicate", Professor="Kobus", 
                    Begin_date = new DateTime(2020, 9, 6), End_date = new DateTime(2020, 10, 30), Filled = false, Image = null, Mentor="Kobus", Pay= 1500, Search_tags= ""},
                new Opportunity{Name = "Compiler Fuzzer Research", Description="Help us improve C Smith", Professor="Eide",
                    Begin_date =  new DateTime(2020, 5, 21), End_date =  new DateTime(2020, 12, 30), Filled = false, Image = null, Mentor="Richard", Pay= 5000, Search_tags= ""},
                new Opportunity{Name = "Corona Virus Social Impact", Description="Research the socialogical impact of the Corona Virus Pandemic", Professor="Cole",
                    Begin_date = new DateTime(2020, 7, 11), End_date = new DateTime(2020, 12, 15), Filled = false, Image = null, Mentor="Cole", Pay= 3000,  Search_tags= ""},
                new Opportunity{Name = "Water System Irrigation", Description="Research new ways to securely irrigate water", Professor="Barber",
                    Begin_date = new DateTime(2020, 1, 1), End_date = new DateTime(2021, 12, 31), Filled = false, Image = null, Mentor="Radomski", Pay= 2700,  Search_tags= ""},
                new Opportunity{Name = "Market Impact of Corona Virus", Description="Research the market impact of the corona virus", Professor="Bakhsheshy", 
                    Begin_date = new DateTime(2020, 8, 4), End_date = new DateTime(2021, 5, 15), Filled = false, Image = null, Mentor="Werzer", Pay= 3500,  Search_tags= ""},
                new Opportunity{Name = "Educational Game Development", Description="Research the effectiveness of educational games", Professor="Zagal", 
                    Begin_date = new DateTime(2020, 2, 14), End_date = new DateTime(2021, 11, 11), Filled = false, Image = null, Mentor="Steur", Pay= 1300,  Search_tags= ""},
                new Opportunity{Name = "Is sitting the new smoking?", Description="Research the health impact of sitting for long periods of time", Professor="Botkin",
                    Begin_date = new DateTime(2020, 1, 10), End_date = new DateTime(2021, 1, 10), Filled = false, Image = null, Mentor="Hull", Pay= 4500,  Search_tags= ""},
                new Opportunity{Name = "Earthquake detection", Description="Research new ways to predict earthquakes", Professor="Cerling",
                    Begin_date = new DateTime(2020, 3, 8), End_date = new DateTime(2021, 4, 20), Filled = false, Image = null, Mentor="Hesketh", Pay= 100,  Search_tags= ""}
            };
            foreach (Opportunity o in opportunities)
            {
                context.Opportunity.Add(o);
            }

            context.SaveChanges();

            
        }
    }
}