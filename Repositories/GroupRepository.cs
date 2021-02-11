using Context;
using Entities;
using Repositories.Generic;
using Repositories.Interfaces;

namespace Repositories
{
    public class GroupRepository : DbRepository<Group>, IGroupRepository
    {
        public GroupRepository(AppDbContext context) : base(context)
        {
        }
    }
}
