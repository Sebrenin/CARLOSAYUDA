using System;
using System.Collections.Generic;

namespace GymRoom_Data.Models;

public partial class CatExercise
{
    public int IdExercises { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CatRoutine> CatRoutines { get; set; } = new List<CatRoutine>();
}
