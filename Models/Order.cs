using PROJET_C__GESTIONRESTO.Usefull.Interface;
using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Order : IHasTimestamp
{

    public Order() { 
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
    public int Id { get; set; }

    public string? NumCom { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? Client { get; set; }

    public int? Zone { get; set; }

    public int? Table { get; set; }

    public virtual Client? ClientNavigation { get; set; } = null!;

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();

    public virtual Table? TableNavigation { get; set; } = null!;

    public virtual Zone? ZoneNavigation { get; set; } = null!;


}
