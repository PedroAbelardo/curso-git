using System;
using System.Collections.Generic;
using System.Text;

namespace ExPropostoSecao7.Entities.Enum
{
    enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
