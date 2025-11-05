using System;
using System.Collections.Generic;

namespace GymRoom_Data.Models;

public partial class TblMember
{
    public int IdMember { get; set; }

    public string? NameMember { get; set; }

    public bool? Active { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Weight { get; set; }

    public int? IdRoutine { get; set; }

    public int? IdCoach { get; set; }

    public virtual CatCoach? IdCoachNavigation { get; set; }

    public virtual CatRoutine? IdRoutineNavigation { get; set; }
}
