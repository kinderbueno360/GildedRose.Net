using GildedRoseApp.Domain;
using GildedRoseApp.Domain.Model;
using GildedRoseApp.Domain.Model.Interfaces;
using System.Collections.Generic;

namespace GildedRoseApp.Application
{
    public class GildedRose : IGildedRose
    {
        IList<Item> Items;
        public GildedRose()
        {
            this.Items = new List<Item>();
        }

        public GildedRose AddItem(string name, int sellIn, int quantity = 0)
        {
            this.Items.Add(ItemFactory.Create(name, sellIn, quantity));
            return this;
        }

        public IList<Item> GetItems()
        {
            return this.Items;
        }
        public void Update()
        {
            foreach (IItemBase item in Items)
            {
                item.Update();
            }
        }
    }
}
