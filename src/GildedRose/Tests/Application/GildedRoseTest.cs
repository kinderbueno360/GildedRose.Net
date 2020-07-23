using Xunit;
using System.Collections.Generic;
using GildedRoseApp.Infrastructure.CrossCutting;
using GildedRoseApp.Application;

namespace GildedRoseApp.ConsoleApplication.Tests.Application
{
    public class GildedRoseTest
    {
        [Fact]
        public void Test_GildedRose_AddItem_Name_ReturnOk()
        {
            // Arrange
            IGildedRose app = DependencyInjector.Instance.GetService<IGildedRose>();
            app.AddItem("foo", 0, 0);

            //Act
            var items = app.GetItems();

            //Assert
            Assert.Equal("foo", items[0].Name);
        }

        [Fact]
        public void Test_GildedRose_AddItem_Quality_ReturnOk()
        {
            // Arrange
            IGildedRose app = DependencyInjector.Instance.GetService<IGildedRose>();
            app.AddItem("foo", 0, 0);

            //Act
            var items = app.GetItems();

            //Assert
            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void Test_GildedRose_AddItem_SellIn_ReturnOk()
        {
            // Arrange
            IGildedRose app = DependencyInjector.Instance.GetService<IGildedRose>();
            app.AddItem("foo", 0, 0);

            //Act
            var items = app.GetItems();

            //Assert
            Assert.Equal(0, items[0].SellIn);
        }
    }
}