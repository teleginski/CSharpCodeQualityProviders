using System;
using Example.Controllers;
using Xunit;

namespace Example.Test
{
    public class ValuesControllerTest
    {
        [Fact]
        public void Test1()
        {
            var controller = new ValuesController();
            var response = controller.Get();
            Assert.Equal(new string[] { "value1", "value2" }, response.Value);
        }
    }
}
