using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Client
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Prenom { get; set; }

    public DateTime? DateNaiss { get; set; }

    public string? Tel { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int Employee { get; set; }

    public virtual ICollection<Attribution> Attributions { get; set; } = new List<Attribution>();

    public virtual Employee EmployeeNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
