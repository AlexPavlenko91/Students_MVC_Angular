using Context;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Generic;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ClassRoomRepository:DbRepository<ClassRoom>, IClassRoomRepository 
    {
        public ClassRoomRepository(AppDbContext context): base(context)
        {
        }
    }
}
