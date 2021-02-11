using Context;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Generic;
using Repositories.Interfaces;

namespace Repositories
{
    public class TeacherSubjectRepository : DbRepository<TeacherSubject>, ITeacherSubjectRepository
    {
        public TeacherSubjectRepository(AppDbContext context) : base(context)
        {

        }
    }
}
