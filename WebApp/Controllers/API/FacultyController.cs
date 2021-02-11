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
    [Route("api/faculty")]
    [ApiController]
    public class FacultyController : ApiController<IFacultyRepository, Faculty>
    {
        public FacultyController(IFacultyRepository repository) : base(repository)
        {
        }
    }
}
