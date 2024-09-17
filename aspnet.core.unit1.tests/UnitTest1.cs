using System;
using aspnet_core_unit_1.Controllers;
using Xunit;

namespace aspnet.core.unit1.tests
{
    public class HomeControllerTests
    {
        private HomeController _controller;

        public HomeControllerTests()
        {
            _controller = new HomeController(null);
        }

        [Fact]
        public void CheckCountValue_ThrowsException_WhenValueGreaterThan20()
        {
            // Arrange
            int value = 500;

            // Act & Assert
            Assert.Throws<Exception>(() => _controller.CheckCountValue(value));

        }

        [Fact]
        public void CheckCountValue_DoesNotThrowException_WhenValueLessThan20()
        {
            // Arrange
            int value = 2;

            // Act & Assert
            _controller.CheckCountValue(value);
        }
    }
}
