using GildedRoseApp.Domain.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp.Domain.Model
{
    public abstract class ItemBase : Item, IItemBase
    {
        public int DecreaseRate { get; private set; }

        protected ItemBase() { }

        public ItemBase(string name, int sellIn, int quality, int decreaseRate)
        {
            base.Name = name;
            base.SellIn = sellIn;
            base.Quality = quality;
            this.DecreaseRate = decreaseRate;
            this.QualityEqualize();
        }

        public ItemBase(string name, int sellIn, int quality) : this(name, sellIn, quality, 1)
        {
            
        }

        public abstract void UpdateQuality();

        public virtual void UpdateSellIn()
        {
            this.SellInDegrades(1);
        }

        public virtual void AfterSellIn()
        {
        }

        /// <summary>
        /// This is a template method
        /// </summary>
        public void Update()
        {
            UpdateQuality();
            UpdateSellIn();
            AfterSellIn();
        }

        private int DrecreaseQuality(int quantity)
        {
            return (quantity * this.DecreaseRate);
        }

        protected void QualityDegrades(int quantity)
        {
            this.Quality -= DrecreaseQuality(quantity);
            this.MinimumQualityEqualize();
        }

        protected void QualityIncrease(int quantity)
        {
            this.Quality += quantity;
            this.MaximumQualityEqualize();
        }

        private void QualityEqualize()
        {
            MaximumQualityEqualize();
            MinimumQualityEqualize();
        }

        protected virtual void MaximumQualityEqualize()
        {
            if (this.Quality > 50)
            {
                this.Quality = 50;
            }
        }

        protected virtual void MinimumQualityEqualize()
        {
            if (this.Quality < 0)
            {
                this.Quality = 0;
            }
        }

        protected void QualityZero()
        {
            this.Quality = 0;
        }

        protected void SellInIncrease(int quantity)
        {
            this.SellIn += quantity;
        }

        protected void SellInDegrades(int quantity)
        {
            this.SellIn -= quantity;
        }
    }
}
