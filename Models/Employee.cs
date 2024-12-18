using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Role { get; set; }

    public DateTime CreateadAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
