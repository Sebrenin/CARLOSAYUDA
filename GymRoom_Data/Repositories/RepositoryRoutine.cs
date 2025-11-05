using GymRoom_Data.Interfaces;
using GymRoom_Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRoom_Data.Repositories
{
    public class RepositoryRoutine : IRepositoryRoutine
    {
        private readonly IDbContextFactory<GymRoomContext> _dbContext;

        public RepositoryRoutine(IDbContextFactory<GymRoomContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddRoutine(CatRoutine routine)
        {
            try
            {
                var ctx = _dbContext.CreateDbContext();
                ctx.CatRoutines.Add(routine);
                ctx.SaveChanges();
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
                var ctx = _dbContext.CreateDbContext();
                ctx.CatRoutines.Update(routine);
                ctx.SaveChanges();
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
                var ctx = _dbContext.CreateDbContext();
                ctx.CatRoutines.Remove(routine);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<CatRoutine> GetAllRoutines()
        {
            var ctx = _dbContext.CreateDbContext();
            return ctx.CatRoutines.ToList();
        }

        public List<CatRoutine> SearchRoutines(string routine)
        {
            var ctx = _dbContext.CreateDbContext();
            var lstRoutines = ctx.CatRoutines.Where(x => x.Name.Contains(routine) || x.Description.Contains(routine)).ToList();
            return lstRoutines;
        }
    }
}
