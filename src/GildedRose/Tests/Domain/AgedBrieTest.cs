using GildedRoseApp.Application;
using GildedRoseApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRoseApp.ConsoleApplication.Tests.Domain
{
    public class AgedBrieTest
    {
        [Fact]
        public void Test_AgedBrie_Update_MaximumMinimum_ReturnIcreaseOne()
        {
            // Arrange
            AgedBrie agedBrie = new AgedBrie("Aged Brie", 2, 0);

            //Act
            agedBrie.Update();

            //Assert
            Assert.Equal(1, agedBrie.Quality);
            Assert.Equal(1, agedBrie.SellIn);
        }

        [Fact]
        public void Test_AgedBrie_Update_MaximumLimits_ReturnOk()
        {
            // Arrange
            AgedBrie agedBrie = new AgedBrie("Aged Brie", 1, 50);

            //Act
            agedBrie.Update();

            //Assert
            Assert.Equal(50, agedBrie.Quality);
            Assert.Equal(0, agedBrie.SellIn);
        }

        [Fact]
        public void Test_AgedBrie_Update_MinimumLimits_ReturnOk()
        {
            // Arrange
            AgedBrie agedBrie = new AgedBrie("Aged Brie", 1, -5);

            //Act
            agedBrie.Update();

            //Assert
            Assert.Equal(1, agedBrie.Quality);
        }
    }
}
