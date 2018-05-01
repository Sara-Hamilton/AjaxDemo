using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AjaxDemo.Models
{
    public class DbInitializer
    {
        public static void Initialize(AjaxDemoContext context)
        {
            if (context.Destinations.Any())
            {
                return;
            }

            var destinations = new Destination[]
            {
                new Destination(){ City = "Portland", Country = "USA"},
                new Destination(){ City = "Paris", Country = "France"},
                new Destination(){ City = "Dubrovnik", Country = "Croatia"},
                new Destination(){ City = "Berlin", Country = "Germany"},
                new Destination(){ City = "Barcelona", Country = "Spain"},
                new Destination(){ City = "Lima", Country = "Peru"},
                new Destination(){ City = "Port au Prince", Country = "Haiti"},
            };

            foreach (Destination d in destinations)
            {
                context.Destinations.Add(d);
            }

            context.SaveChanges();
        }
    }
}
