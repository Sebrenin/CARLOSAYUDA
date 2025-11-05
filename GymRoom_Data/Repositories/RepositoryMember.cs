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
    public class RepositoryMember : IRepositoryMember
    {
        private readonly IDbContextFactory<GymRoomContext> _dbContext;

        public RepositoryMember(IDbContextFactory<GymRoomContext> dbContext)
        {
            _dbContext = dbContext;
        }

    public void AddMember(TblMember tblMember)
        {
            try
            {
                var ctx = _dbContext.CreateDbContext();
                ctx.TblMembers.Add(tblMember);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
