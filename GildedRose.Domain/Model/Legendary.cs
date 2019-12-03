using GildedRoseApp.Domain.Annotation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp.Domain.Model
{
    [ItemName("Sulfuras")]
    public class Legendary : ItemBase
    {
        public Legendary(string name, int sellIn) : base(name, sellIn, 80, 1)
        {
        }

        protected override void MaximumQualityEqualize()
        {
            // Legendary rule: Do nothing
        }

        protected override void MinimumQualityEqualize()
        {
            // Legendary rule: Do nothing
        }
        public override void UpdateQuality()
        {
            // Legendary rule: Do nothing
        }

        public override void UpdateSellIn()
        {
            // Legendary rule: Do nothing
        }

    }
}
