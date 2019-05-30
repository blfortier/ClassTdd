using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDStore.Core;
using TDDStore.Core.Exceptions;
using Telerik.JustMock;
using Assert = NUnit.Framework.Assert;

namespace TDDStore.UnitTests
{
    [TestFixture]
    public class OrderServiceTests
    {
        private OrderService _orderService;
        private IOrderDataService _orderDataService;
        private ICustomerService _customerService;

        [SetUp]
        public void SetupTestFixture()
        {
            _orderDataService = Mock.Create<IOrderDataService>();
            _orderService = new OrderService(_orderDataService, _customerService);
            _customerService = Mock.Create<ICustomerService>();
        }

        [Test]
        public void WhenUserPlacesACorrectOrderThenAnOrderNumberShouldBeReturned()
        {
            // Arrange
            var shoppingCart = new ShoppingCart();
            shoppingCart.Items.Add(new ShoppingCartItem { ItemId = Guid.NewGuid(), Quantity = 1 });
            var customerId = Guid.NewGuid();
            var expectedOrderId = Guid.NewGuid();

            Mock.Arrange(() => _orderDataService.Save(Arg.IsAny<Order>()))
                                .Returns(expectedOrderId)
                                .OccursOnce();

            // Act
            var result = _orderService.PlaceOrder(customerId, shoppingCart);

            // Assert
            Assert.AreEqual(expectedOrderId, result);
            Mock.Assert(_orderDataService);
        }

        [Test]
        public void WhenAUserAttemptsToOrderAnItemWithAQuantityOfZeroThrowInvalidOrderException()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Items.Add(new ShoppingCartItem { ItemId = Guid.NewGuid(), Quantity = 0 });
            var customerId = Guid.NewGuid();
            var expectedOrderId = Guid.NewGuid();

            Mock.Arrange(() => _orderDataService.Save(Arg.IsAny<Order>()))
                                 .Returns(expectedOrderId)
                                 .OccursNever();
            // Act
            try
            {
                _orderService.PlaceOrder(customerId, shoppingCart);
            }
            catch
            {
                // Assert
                Mock.Assert(_orderDataService);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void WhenAValidCustomerPlacesAValidOrderAnOrderShouldBePlaced()
        {
            //Arrange
            var shoppingCart = new ShoppingCart();
            shoppingCart.Items.Add(new ShoppingCartItem { ItemId = Guid.NewGuid(), Quantity = 1 });
            var customerId = Guid.NewGuid();

            var customerToReturn = new Customer { Id = customerId, FirstName = "Fred", LastName = "Flinstone" };

            Mock.Arrange(() => _customerService.GetCustomer(customerId))
                                    .Returns(customerToReturn)
                                    .OccursOnce();

            //Act
            _orderService.PlaceOrder(customerId, shoppingCart);

            // Assert
            Mock.Assert(_customerService);
        }
    }
}