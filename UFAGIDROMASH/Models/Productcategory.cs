using System;
using System.Collections.Generic;

namespace UFAGIDROMASH.Models;

public partial class Productcategory
{
    public int ProductCategoryId { get; set; }

    public string ProductCategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
