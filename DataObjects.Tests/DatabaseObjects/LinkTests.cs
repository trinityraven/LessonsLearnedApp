using System;
using DataObjects.DatabaseObjects;
using DataObjects.Enums;
using Xunit;

namespace DataObjects.Tests.DatabaseObjects
{
    public class LinkTests
    {
        [Fact]
        public void TestToString()
        {
            var data = new Link
            {
                Name = "TestName",
                Description = "TestDescription",
                URL = "http://a.web.link.com",
                LinkType = LinkType.Web
            };

            var expected = "TestName (TestDescription) Web: http://a.web.link.com";

            var actual = data.ToString();

            Assert.Equal(expected, actual);
        }
    }
}