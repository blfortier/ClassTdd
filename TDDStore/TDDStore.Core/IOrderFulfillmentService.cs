using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDStore.Core
{
    public interface IOrderFulfillmentService
    {

        Guid OpenSession(string user, string password);

        bool IsInInventory(Guid sessionId, Guid ItemNumber, int quantity);

        bool PlaceOrder(Guid sessionId, IDictionary<Guid, int> items, string mailingAddress);

        void CloseSession(Guid sessionId);
    }
}
