using NUnit.Framework;
using Should;
using UnitTesting.Domain;

namespace UnitTesting.Tests
{
    [TestFixture]
    public class CarCreationServiceTests
    {
        private CarCreationService _teslaCreationService;

        [SetUp]
        public void Setup()
        {
            _teslaCreationService = new CarCreationService();
        }

        [Test]
        public void should_create_tesla_make()
        {
            var result = _teslaCreationService.CreateTesla("S");

            result.Make.ShouldEqual("Tesla");
        }

        [Test]
        public void should_create_tesla_model()
        {
            var result = _teslaCreationService.CreateTesla("S");

            result.Model.ShouldEqual("S");
        }
    }
}
