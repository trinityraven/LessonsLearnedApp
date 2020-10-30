using System.ComponentModel.DataAnnotations;
using Xunit;
using DataObjects.Extensions;

namespace DataObjects.Tests.Extensions
{
    public class EnumExtensionTests
    {
        private enum TestEnum
        {
            [Display(Name="AnnotationText")]
            Annotated,
            Unannotated
        };

        [Fact]
        public void TestGetDescriptionAnnotated()
        {
            const string EXPECTED = "AnnotationText";

            const TestEnum TESTER = TestEnum.Annotated;
            var actual = TESTER.GetDescription();

            Assert.Equal(EXPECTED, actual);
        }

        [Fact]
        public void TestGetDescriptionUnannotated()
        {
            const string EXPECTED = "Unannotated";

            const TestEnum TESTER = TestEnum.Unannotated;
            var actual = TESTER.GetDescription();

            Assert.Equal(EXPECTED, actual);
        }
    }
}
