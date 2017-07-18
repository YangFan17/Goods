namespace WebApplication1.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.GoodsDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApplication1.Models.GoodsDBContext context)
        {
            context.Goods.AddOrUpdate(i => i.Name,
                new Goods
                {
                    Name = "Bolt driver",
                    Date = DateTime.Parse("2015-1-11"),
                    Genre = "Tools",
                    Price = 5M
                },

                 new Goods
                 {
                     Name = "Breads",
                     Date = DateTime.Parse("2017-3-13"),
                     Genre = "Foods",
                     Price = 10M
                 },

                 new Goods
                 {
                     Name = "Flour",
                     Date = DateTime.Parse("2017-2-23"),
                     Genre = "Foods",
                     Price = 45M
                 },

               new Goods
               {
                   Name = "Toothbrush",
                   Date = DateTime.Parse("2016-4-15"),
                   Genre = "Daily Use",
                   Price = 7M
               }
           );

        }
    }
}
