using Context;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Generic;
using Repositories.Interfaces;

namespace Repositories
{
    public class MarksRepository : DbRepository<Marks>, IMarksRepository
    {
        public MarksRepository(AppDbContext context) : base(context)
        {
        }
    }
}
