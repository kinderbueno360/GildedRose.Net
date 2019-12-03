using GildedRoseApp.Domain.Annotation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp.Domain.Model
{
    [ItemName("Conjured")]
    public class Conjured : ItemBase
    {
        public Conjured(string name, int sellIn, int quality) : base(name, sellIn, quality, 2)
        { }
        public override void UpdateQuality()
        {
            if (SellIn < 0)
                base.QualityDegrades(2);
            else
                base.QualityDegrades(1);
        }
    }
}
