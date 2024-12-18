using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Attribution
{
    public int Id { get; set; }

    public string? State { get; set; }

    public DateTime? StartAt { get; set; }

    public DateTime? FinishAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int Client { get; set; }

    public int Table { get; set; }

    public virtual Client ClientNavigation { get; set; } = null!;

    public virtual Table TableNavigation { get; set; } = null!;
}
