using GildedRoseApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRoseApp.ConsoleApplication.Tests.Domain
{
    public class BackstageTest
    {
        [Fact]
        public void Test_Backstage_Update_Increse1_ReturnOk()
        {
            // Arrange
            Backstage backstage = new Backstage("Backstage", 12, 0);

            //Act
            backstage.Update();

            //Assert
            Assert.Equal(1, backstage.Quality);
            Assert.Equal(11, backstage.SellIn);
        }

        [Fact]
        public void Test_Backstage_Update_Increse2_ReturnOk()
        {
            // Arrange
            Backstage backstage = new Backstage("Backstage", 7, 0);

            //Act
            backstage.Update();

            //Assert
            Assert.Equal(2, backstage.Quality);
            Assert.Equal(6, backstage.SellIn);
        }

        [Fact]
        public void Test_Backstage_Update_Increse3_ReturnOk()
        {
            // Arrange
            Backstage backstage = new Backstage("Backstage", 2, 0);

            //Act
            backstage.Update();

            //Assert
            Assert.Equal(3, backstage.Quality);
            Assert.Equal(1, backstage.SellIn);
        }

        [Fact]
        public void Test_Backstage_Update_QualityZero_ReturnOk()
        {
            // Arrange
            Backstage backstage = new Backstage("Backstage", -1, 30);

            //Act
            backstage.Update();

            //Assert
            Assert.Equal(0, backstage.Quality);
            Assert.Equal(-2, backstage.SellIn);
        }
    }
}
