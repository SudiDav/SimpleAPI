using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Sudi David", returnValue.Value);
        }   
       
        [Fact]
        public void Test()
        {

        }
    }
}
