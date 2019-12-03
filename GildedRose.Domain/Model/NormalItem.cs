using GildedRoseApp.Domain.Annotation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp.Domain.Model
{
    [ItemName("Default")]
    public class NormalItem : ItemBase
    {
        public NormalItem(string name, int sellIn, int quality) : base(name, sellIn, quality, 1)
        {
        }

        public override void AfterSellIn()
        {
            if (SellIn < 0)
                base.QualityDegrades(1);
        }

        public override void UpdateQuality()
        {
            base.QualityDegrades(1);
        }
    }
}
