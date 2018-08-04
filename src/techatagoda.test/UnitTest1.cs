using System;
using Xunit;
using teachatagoda.Services;

namespace techatagoda.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var nameService = new NameService();
            var actual = nameService.GetName("test");
            var expect = "test1";
            Assert.Equal(expect, actual);
        }
    }
}
