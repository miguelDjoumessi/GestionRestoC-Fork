using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Table
{
    public int Id { get; set; }

    public string? Position { get; set; }

    public int? Capacity { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual ICollection<Attribution> Attributions { get; set; } = new List<Attribution>();
}
