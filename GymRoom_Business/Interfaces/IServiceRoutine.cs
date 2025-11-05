using GymRoom_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRoom_Business.Interfaces
{
    public interface IServiceRoutine
    {
        public void AddRoutine(CatRoutine routine);
        public void EditRoutine(CatRoutine routine);
        public void DeleteRoutine(CatRoutine routine);
        public List<CatRoutine> GetAllRoutines();
        public List<CatRoutine> SearchRoutines(string routine);
    }
}
