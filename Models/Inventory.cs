using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Inventory
{
    public int Id { get; set; }

    public string? Designation { get; set; }

    public int Quantity { get; set; }

    public string Unity { get; set; } = null!;

    public string? Type { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? Category { get; set; }

    public virtual ICollection<Cartitem> Cartitems { get; set; } = new List<Cartitem>();

    public virtual Category? CategoryNavigation { get; set; }
}
