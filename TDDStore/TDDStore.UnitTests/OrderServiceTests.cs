using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDStore.Core;
using Telerik.JustMock;

namespace TDDStore.UnitTests
{
    [TestFixture]
    public class OrderServiceTests
    {
        [Test]
        public void WhenUserPlacesACorrectOrderThenAnOrderNumberShouldBeReturned()
        {
            // Arrange
            var shoppingCart = new ShoppingCart();
            shoppingCart.Items.Add(new ShoppingCartItem { ItemId = Guid.NewGuid(), Quantity = 1 });
            var customerId = Guid.NewGuid();
            var expectedOrderId = Guid.NewGuid();

            var orderDataService = Mock.Create<IOrderDataService>();
            Mock.Arrange(() => orderDataService.Save(Arg.IsAny<Order>())).Returns(expectedOrderId);

            OrderService orderService = new OrderService(orderDataService);

            // Act
            var result = orderService.PlaceOrder(customerId, shoppingCart);

            // Assert
            Assert.AreEqual(expectedOrderId, result);

        }
    }
}
