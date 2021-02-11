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
    [Route("api/student")]
    [ApiController]
    public class StudentController : ApiController<IStudentRepository, Student>
    {
        public StudentController(IStudentRepository repository) : base(repository)
        {
        }
    }
}
