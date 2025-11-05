using System;
using System.Collections.Generic;

namespace GymRoom_Data.Models;

public partial class CatRoutine
{
    public int IdRoutine { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? IdExercises { get; set; }

    public virtual CatExercise? IdExercisesNavigation { get; set; }

    public virtual ICollection<TblMember> TblMembers { get; set; } = new List<TblMember>();
}
