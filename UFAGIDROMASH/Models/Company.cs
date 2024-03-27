using System;
using System.Collections.Generic;

namespace UFAGIDROMASH.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string CompanyDelegate { get; set; } = null!;

    public int CompanyInn { get; set; }

    public string CompanyAddress { get; set; } = null!;

    public string CompanyLogin { get; set; } = null!;

    public string CompanyPassword { get; set; } = null!;

    public virtual ICollection<Agreement> Agreements { get; } = new List<Agreement>();
}
