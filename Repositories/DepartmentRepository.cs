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
    public class DepartmentRepository : DbRepository<Department>, IDepartmentRepository 
    {
        public DepartmentRepository(AppDbContext context): base(context)
        {
        }
    }
}
