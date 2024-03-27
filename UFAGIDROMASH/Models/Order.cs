using System;
using System.Collections.Generic;

namespace UFAGIDROMASH.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? OrderProductPart { get; set; }

    public int? OrderServicePart { get; set; }

    public int OrderCost { get; set; }

    public virtual Productpart? OrderProductPartNavigation { get; set; }

    public virtual Servicepart? OrderServicePartNavigation { get; set; }
}
