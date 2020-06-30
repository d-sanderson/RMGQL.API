using Newtonsoft.Json;
using RMGQL.API.Data.Entities;
using System;
using System.IO;

namespace RMGQL.API.Data
{
    public static class InitialData
    {

        public static void Seed(this QuoteDbContext dbContext)
        {

            var json = JsonConvert.DeserializeObject<Quote[]>(
                File.ReadAllText(@"C:\Users\David\source\repos\RMGQL.API\RMGQL.API\Data\quotes.json"));


            Console.WriteLine(json);
            foreach (var quote in json)
            {
                dbContext.Quotes.Add(new Quote()
                {
                    Character = quote.Character,
                    Episode = quote.Episode,
                    Excerpt = quote.Excerpt
                });
                dbContext.SaveChanges();
            }


        }
    }
}
