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
    [Route("api/teacher")]
    [ApiController]
    public class TeacherController : ApiController<ITeacherRepository, Teacher>
    {
        public TeacherController(ITeacherRepository repository):base(repository) 
        {
        }
    }
}
