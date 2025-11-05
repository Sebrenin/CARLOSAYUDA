using GymRoom_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRoom_Data.Interfaces
{
    public interface IRepositoryRoutine
    {
        public void AddRoutine(CatRoutine routine);
        public void EditRoutine(CatRoutine routine);
        public void DeleteRoutine(CatRoutine routine);
        public List<CatRoutine> GetAllRoutines();
        List<CatRoutine> SearchRoutines(string routine);
    }
}
