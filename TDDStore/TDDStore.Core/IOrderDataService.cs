using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDStore.Core
{   
    public interface IOrderDataService
    {
        Guid Save(Order order);
    }
}
