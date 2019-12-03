using GildedRoseApp.Infrastructure.CrossCutting;
using GildedRoseApp.Application;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace GildedRoseApp.ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            
            var app = DependencyInjector.Instance.GetService<IGildedRose>();

            app.AddItem("+5 Dexterity Vest", 10, 20)
                .AddItem("Aged Brie", 2, 0)
                .AddItem("Elixir of the Mongoose", 5, 7)
                .AddItem("Sulfuras, Hand of Ragnaros", 0, 80)
                .AddItem("Sulfuras, Hand of Ragnaros", -1, 80)
                .AddItem("Backstage passes to a TAFKAL80ETC concert", 15, 20)
                .AddItem("Backstage passes to a TAFKAL80ETC concert", 10, 49)
                .AddItem("Backstage passes to a TAFKAL80ETC concert", 5, 49)
                .AddItem("Conjured Mana Cake", 3, 6);

            var Items = app.GetItems();

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                }
                Console.WriteLine("");
                app.Update();
            }
        }
    }
}
