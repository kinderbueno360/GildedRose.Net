using GildedRoseApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRoseApp.ConsoleApplication.Tests.Domain
{
    public class NormalItemTest
    {
        [Fact]
        public void Test_NormalItem_Update_MaximumQuality_ReturnOk()
        {
            // Arrange
            NormalItem normalItem = new NormalItem("Teste 1234", 12, 60);

            //Act
            normalItem.Update();

            //Assert
            Assert.Equal(49, normalItem.Quality);
            Assert.Equal(11, normalItem.SellIn);
        }

        [Fact]
        public void Test_NormalItem_Update_DegreaseFaster_ReturnOk()
        {
            // Arrange
            NormalItem normalItem = new NormalItem("Teste 1234", 0, 10);

            //Act
            normalItem.Update();

            //Assert
            Assert.Equal(8, normalItem.Quality);
            Assert.Equal(-1, normalItem.SellIn);
        }
    }
}
