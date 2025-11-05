using GymRoom_Business.Interfaces;
using GymRoom_Data.Interfaces;
using GymRoom_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRoom_Business.Services
{
    public class ServiceRoutine : IServiceRoutine
    {
        private readonly IRepositoryRoutine _repositoryRoutine;

        public ServiceRoutine(IRepositoryRoutine repositoryRoutine)
        {
            _repositoryRoutine = repositoryRoutine;
        }

        public void AddRoutine(CatRoutine routine)
        {
            try
            {
                _repositoryRoutine.AddRoutine(routine);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EditRoutine(CatRoutine routine)
        {
            try
            {
                _repositoryRoutine.EditRoutine(routine);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteRoutine(CatRoutine routine)
        {
            try
            {
                _repositoryRoutine.DeleteRoutine(routine);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<CatRoutine> GetAllRoutines()
        {
            return _repositoryRoutine.GetAllRoutines();
        }

        public List<CatRoutine> SearchRoutines(string search)
        {
            return _repositoryRoutine.SearchRoutines(search);
        }
    }
}

