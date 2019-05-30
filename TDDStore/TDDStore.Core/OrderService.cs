using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDStore.Core.Exceptions;
using Telerik.JustMock;

namespace TDDStore.Core
{
    public class OrderService
    {
        private IOrderDataService _orderDataService;
        private ICustomerService _customerService;

        public OrderService()
        {
        }

        public OrderService(IOrderDataService orderDataService, ICustomerService customerService)
        {
            _orderDataService = orderDataService;
            _customerService = customerService;
        }

        public Guid PlaceOrder(Guid customerId, ShoppingCart shoppingCart)
        {
            foreach (ShoppingCartItem item in shoppingCart.Items)
            {
                if (item.Quantity == 0)
                    throw new InvalidOrderException();
            }
            var customer = _customerService.GetCustomer(customerId);
            var order = new Order();
            return _orderDataService.Save(order);
        }
    }
}
