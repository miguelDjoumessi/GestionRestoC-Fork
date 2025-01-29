using PROJET_C__GESTIONRESTO.Usefull.Interface;
using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Menuitem : IHasTimestamp
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int Product { get; set; }

    public int Menu { get; set; }

    public virtual Menu MenuNavigation { get; set; } = null!;

    public virtual Product ProductNavigation { get; set; } = null!;
}
