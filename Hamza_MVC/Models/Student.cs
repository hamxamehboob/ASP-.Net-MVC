using System;
using System.Collections.Generic;

namespace Hamza_MVC.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Semester { get; set; }

    public string? Department { get; set; }

    public int? EarnedCreditHours { get; set; }
}
