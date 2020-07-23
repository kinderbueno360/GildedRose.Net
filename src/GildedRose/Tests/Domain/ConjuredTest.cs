using GildedRoseApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRoseApp.ConsoleApplication.Tests.Domain
{
    public class ConjuredTest
    {
        [Fact]
        public void Test_Conjured_Update_Twice_ReturnOk()
        {
            // Arrange
            Conjured conjured = new Conjured("Backstage", 12, 2);

            //Act
            conjured.Update();

            //Assert
            Assert.Equal(0, conjured.Quality);
            Assert.Equal(11, conjured.SellIn);
        }
    }
}
