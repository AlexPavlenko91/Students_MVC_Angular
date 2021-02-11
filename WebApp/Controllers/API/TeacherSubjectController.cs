using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [Route("api/teacherSubject")]
    [ApiController]
    public class TeacherSubjectController : ApiController<ITeacherSubjectRepository, TeacherSubject>
    {
        public TeacherSubjectController(ITeacherSubjectRepository repository):base(repository) 
        {
        }
    }
}
