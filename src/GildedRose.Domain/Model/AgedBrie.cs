using GildedRoseApp.Domain.Annotation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp.Domain.Model
{
    [ItemName("Aged Brie")]
    public class AgedBrie : ItemBase
    {
        public AgedBrie(string name, int sellIn, int quality) : base(name, sellIn, quality)
        { }
        public override void UpdateQuality()
        {
            if (base.Quality < 50)
            {
                this.QualityIncrease(1);
            }
        }
    }
}
