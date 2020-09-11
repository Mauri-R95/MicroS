using FluentAssertions;
using MicroService.Domain.Demo;
using MicroService.Unit.Tests.MockRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroService.Unit.Tests
{
    [TestClass]
    public class OrderTest
    {
        Mock<IOrderRepository> _orderRepository = new OrderRepositoryMock()._orderRepository;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            
        }

        [TestMethod]
        public async Task dado_un_id_devuelve_una_order()
        {
            //Ejecucion
            var result = _orderRepository.Object.Get(1);
            //Asercion
            result.Id.Should().NotBe(2);
            result.Should().NotBeNull();
            result.IsCompleted.Should().BeTrue();
        }

        [TestMethod]
        public async Task devuelve_todos_los_admin() {
            var result = _orderRepository.Object.GetAll();
            result.Should().NotBeNull();
            //result.Should().HaveCountGreateOrEqualTo(1);
        
        } 

    }
}