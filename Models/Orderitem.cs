using PROJET_C__GESTIONRESTO.Usefull.Interface;
using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Orderitem : IHasTimestamp
{
    public Orderitem() 
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int Order { get; set; }

    public int Product { get; set; }

    public int Quantity { get; set; }

    public virtual Order OrderNavigation { get; set; } = null!;

    public virtual Product ProductNavigation { get; set; } = null!;
}
