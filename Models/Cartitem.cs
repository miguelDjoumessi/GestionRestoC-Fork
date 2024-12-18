using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Cartitem
{
    public int Id { get; set; }

    public int? Quantity { get; set; }

    public string? Unity { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int Cart { get; set; }

    public int Inventory { get; set; }

    public virtual Cart CartNavigation { get; set; } = null!;

    public virtual Inventory InventoryNavigation { get; set; } = null!;

    public virtual ICollection<Justification> Justifications { get; set; } = new List<Justification>();
}
