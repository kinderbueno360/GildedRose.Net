using GildedRoseApp.Application;
using GildedRoseApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRoseApp.ConsoleApplication.Tests.Application
{
    public class ItemFactoryTest
    {
        [Fact]
        public void Test_ItemFactory_Create_AgedBrie_ReturnOk()
        {
            // Arrange
            AgedBrie agedBrie = new AgedBrie("Aged Brie", 0,0);

            //Act
            var itemCreated = ItemFactory.Create("Aged Brie", 0,0);

            //Assert
            Assert.Equal(itemCreated.GetType(), agedBrie.GetType());
        }

        [Fact]
        public void Test_ItemFactory_Create_Backstage_ReturnOk()
        {
            // Arrange
            Backstage backstage = new Backstage("Backstage", 0, 0);

            //Act
            var itemCreated = ItemFactory.Create("Backstage", 0, 0);

            //Assert
            Assert.Equal(itemCreated.GetType(), backstage.GetType());
        }

        [Fact]
        public void Test_ItemFactory_Create_Conjured_ReturnOk()
        {
            // Arrange
            Conjured conjured = new Conjured("Conjured", 0, 0);

            //Act
            var itemCreated = ItemFactory.Create("Conjured", 0, 0);

            //Assert
            Assert.Equal(itemCreated.GetType(), conjured.GetType());
        }

        [Fact]
        public void Test_ItemFactory_Create_Legendary_ReturnOk()
        {
            // Arrange
            Legendary legendary = new Legendary("Sulfuras", 0);

            //Act
            var itemCreated = ItemFactory.Create("Sulfuras", 0);

            //Assert
            Assert.Equal(itemCreated.GetType(), legendary.GetType());
        }
        [Fact]
        public void Test_ItemFactory_Create_NormalItem_ReturnOk()
        {
            // Arrange
            NormalItem normalItem = new NormalItem("Normal Test", 0, 0);

            //Act
            var itemCreated = ItemFactory.Create("Normal Test", 0, 0);

            //Assert
            Assert.Equal(itemCreated.GetType(), normalItem.GetType());
        }
    }
}
