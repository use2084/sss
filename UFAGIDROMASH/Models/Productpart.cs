using System;
using System.Collections.Generic;

namespace UFAGIDROMASH.Models;

public partial class Productpart
{
    public int ProductPartId { get; set; }

    public int ProductArticle { get; set; }

    public int AgreementId { get; set; }

    public int QuantityProduct { get; set; }

    public virtual Agreement Agreement { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual Product ProductArticleNavigation { get; set; } = null!;
}
