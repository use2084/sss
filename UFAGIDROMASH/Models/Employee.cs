using System;
using System.Collections.Generic;

namespace UFAGIDROMASH.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeFirstName { get; set; } = null!;

    public string EmployeeName { get; set; } = null!;

    public string? EmployeePatronymic { get; set; }

    public DateOnly EmployeeBirthday { get; set; }

    public string EmployeePassport { get; set; } = null!;

    public string EmployeePhone { get; set; } = null!;

    public int EmployeePost { get; set; }

    public string EmployeeLogin { get; set; } = null!;

    public string EmployeePassword { get; set; } = null!;

    public int EmployeeStatus { get; set; }

    public virtual ICollection<Agreement> Agreements { get; } = new List<Agreement>();

    public virtual Post EmployeePostNavigation { get; set; } = null!;

    public virtual Statusemployee EmployeeStatusNavigation { get; set; } = null!;
}
