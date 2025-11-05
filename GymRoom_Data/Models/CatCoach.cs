using System;
using System.Collections.Generic;

namespace GymRoom_Data.Models;

public partial class CatCoach
{
    public int IdCoach { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<TblMember> TblMembers { get; set; } = new List<TblMember>();
}
