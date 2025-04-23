using System;
using System.Collections.Generic;

namespace CodeFirstApproach.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public DateTime? HireDate { get; set; }

    public decimal Salary { get; set; }

    public string Department { get; set; } = null!;

    public string Position { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}
