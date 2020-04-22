using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;
using System.Linq;

namespace SamuraiApp.Console
{
    class Program
    {
        private static SamuraiContext context = new SamuraiContext();
        static void Main(string[] args)
        {
            context.Database.EnsureCreated();
            GetSamurais("Before Add:");
            AddSamurai();
            GetSamurais("After Add:");
        }

        private static void AddSamurai()
        {
            var samurai = new Samurai { Name = "Tamara" };
            context.Samurais.Add(samurai);
            context.SaveChanges();
        }

        private static void GetSamurais(string text)
        {
            var samurais = context.Samurais.ToList();
            System.Console.WriteLine($"{text}: Samurai coint is {samurais.Count}");

            foreach (var samurai in samurais)
            {
                System.Console.WriteLine(samurai.Name);
            }
        }
    }
}
