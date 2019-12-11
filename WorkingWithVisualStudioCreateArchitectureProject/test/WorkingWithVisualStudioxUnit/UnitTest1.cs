using System;
using WorkingWithVisualStudioCreateArchitectureProject.Models;
using Xunit;

namespace WorkingWithVisualStudioxUnit
{
    public class UnitTest1
    {
        [Fact]
        public void CanChangeProductName()
        {
            //arrange
            var p = new Product() {Name = "AA", Price=100 };

            //act
            p.Name = "Alex";

            //assert
            Assert.Equal("Alex", p.Name);
        }
    }
}
