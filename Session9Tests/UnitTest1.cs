using Microsoft.AspNetCore.Mvc;
using Session9.Controllers;
using Session9.Model;
using Session9.Services;

namespace Session9Tests
{
    public class UnitTest1
    {
        private readonly BookController _controller;
        private readonly IBookService _service;

        public UnitTest1()
        {

            _service = new BookService();
            _controller = new BookController(_service);
        }

        [Fact]
        public void Test1()
        {
            var okResult = _controller.GetAll();
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public void Test2()
        {
            // Act
            var okResult = _controller.GetAll() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Books>>(okResult.Value);
            Assert.True(items.Count > 0);
        }
        [Fact]
        public void Test3()
        {
            var result = 2 + 3;
            Assert.Equal(7, result);
        }
    }
}