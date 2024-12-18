using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Justification
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int Product { get; set; }

    public int CartItem { get; set; }

    public virtual Cartitem CartItemNavigation { get; set; } = null!;

    public virtual Product ProductNavigation { get; set; } = null!;
}
