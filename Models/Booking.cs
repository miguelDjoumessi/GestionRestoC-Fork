using PROJET_C__GESTIONRESTO.Usefull.Interface;
using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Booking: IHasTimestamp
{
    public int Id { get; set; }

    public string? State { get; set; }

    public decimal? Tarif {  get; set; }

    public string? requestState {  get; set; }

    public int? Persons { get; set; }

    public string? Period {  get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int Client { get; set; }

    public int Table { get; set; }

    public virtual Client ClientNavigation { get; set; } = null!;

    public virtual Table TableNavigation { get; set; } = null!;
}
