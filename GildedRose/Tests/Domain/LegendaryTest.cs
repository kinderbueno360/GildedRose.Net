using GildedRoseApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRoseApp.ConsoleApplication.Tests.Domain
{
    public class LegendaryTest
    {
        [Fact]
        public void Test_Legendary_Update_NeverSaleOrDecreasesQuality_ReturnOk()
        {
            // Arrange
            Legendary legendary = new Legendary("Sulfuras", 12);

            //Act
            legendary.Update();

            //Assert
            Assert.Equal(80, legendary.Quality);
            Assert.Equal(12, legendary.SellIn);
        }
    }
}
