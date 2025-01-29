using PROJET_C__GESTIONRESTO.Usefull.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Product : IHasTimestamp
{
    public int Id { get; set; }

    public string? Designation { get; set; }

    public string? Description { get; set; }

    public float? UnityPrice { get; set; }

    [NotMapped]
    public int? Quantity { get; set; } = 0;

    public string? Image { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? Category { get; set; }

    //[ForeignKey("Category")]
    //[InverseProperty("Products")]
    public virtual Category? CategoryNavigation { get; set; }

    public virtual ICollection<Justification> Justifications { get; set; } = new List<Justification>();

    public virtual ICollection<Menuitem> Menuitems { get; set; } = new List<Menuitem>();

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();
}
