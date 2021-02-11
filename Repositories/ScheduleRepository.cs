using Context;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Generic;
using Repositories.Interfaces;

namespace Repositories
{
    public class ScheduleRepository : DbRepository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(AppDbContext context) : base(context)
        {

        }
    }
}
