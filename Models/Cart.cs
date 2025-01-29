using PROJET_C__GESTIONRESTO.Usefull.Interface;
using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Cart : IHasTimestamp
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Cartitem> Cartitems { get; set; } = new List<Cartitem>();
}
