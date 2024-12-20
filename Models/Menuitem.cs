﻿using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Menuitem
{
    public int Id { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int Product { get; set; }

    public int Menu { get; set; }

    public virtual Menu MenuNavigation { get; set; } = null!;

    public virtual Product ProductNavigation { get; set; } = null!;
}
