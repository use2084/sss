using System;
using System.Collections.Generic;

namespace UFAGIDROMASH.Models;

public partial class Agreement
{
    public int AgreementId { get; set; }

    public int AgreementEmployee { get; set; }

    public DateOnly AgreementDate { get; set; }

    public int AgreementCost { get; set; }

    public int AgreementCompany { get; set; }

    public virtual Company AgreementCompanyNavigation { get; set; } = null!;

    public virtual Employee AgreementEmployeeNavigation { get; set; } = null!;

    public virtual ICollection<Productpart> Productparts { get; } = new List<Productpart>();

    public virtual ICollection<Servicepart> Serviceparts { get; } = new List<Servicepart>();
}
