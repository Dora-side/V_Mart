using System;
using System.Collections.Generic;

namespace Project_Sem7.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public string Password { get; set; } = null!;
}
