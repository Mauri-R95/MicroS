using MicroService.Domain.Demo;
using MicroService.Unit.Tests.Stubs;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Unit.Tests.MockRepository
{
    class OrderRepositoryMock
    {
        public Mock<IOrderRepository> _orderRepository { get; set; }

        public OrderRepositoryMock()
        {
            _orderRepository = new Mock<IOrderRepository>();
            Setup();
        }

        private void Setup()
        {
            _orderRepository.Setup((x) => x.GetAll()).ReturnsAsync(OrderStub.orders);
            _orderRepository.Setup((x) => x.Get(It.IsAny<int>())).ReturnsAsync(OrderStub.order);
            _orderRepository.Setup((x) => x.GetItem(It.IsAny<int>())).ReturnsAsync(OrderStub.item);
            _orderRepository.Setup((x) => x.GetAllItem()).ReturnsAsync(OrderStub.items);
        }

    }
}
