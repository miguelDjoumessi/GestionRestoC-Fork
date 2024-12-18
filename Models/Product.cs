using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Designation { get; set; }

    public string? Description { get; set; }

    public float? UnityPrice { get; set; }

    public string? Image { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? Category { get; set; }

    public virtual Category? CategoryNavigation { get; set; }

    public virtual ICollection<Justification> Justifications { get; set; } = new List<Justification>();

    public virtual ICollection<Menuitem> Menuitems { get; set; } = new List<Menuitem>();

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();
}
