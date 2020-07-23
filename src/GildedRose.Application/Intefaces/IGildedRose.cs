using GildedRoseApp.Domain;
using System.Collections.Generic;

namespace GildedRoseApp.Application
{
    public interface IGildedRose
    {
        GildedRose AddItem(string name, int sellIn, int quantity);

        void Update();

        IList<Item> GetItems();
    }
}