using GildedRoseApp.Domain.Annotation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp.Domain.Model
{
    [ItemName("Backstage")]
    public class Backstage : ItemBase
    {
        public Backstage(string name, int sellIn, int quality) : base(name, sellIn, quality)
        { }
        public override void UpdateQuality()
        {

            if (SellIn > 10)
                base.QualityIncrease(1);
            else if (SellIn > 5)
                base.QualityIncrease(2);
            else if (SellIn >= 0)
                base.QualityIncrease(3);
        }

        public override void AfterSellIn()
        {
            if (SellIn < 0)
                base.QualityZero();
        }
    }
}
