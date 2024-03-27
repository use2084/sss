using System;
using System.Collections.Generic;

namespace UFAGIDROMASH.Models;

public partial class Servicepart
{
    public int ServicePartId { get; set; }

    public int ServiceId { get; set; }

    public int AgreementId { get; set; }

    public int ServiceQuantity { get; set; }

    public virtual Agreement Agreement { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual Service Service { get; set; } = null!;
}
