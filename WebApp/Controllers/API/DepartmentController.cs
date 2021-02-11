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
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : ApiController<IDepartmentRepository, Department>
    {
        public DepartmentController(IDepartmentRepository repository):base(repository) 
        {
        }
    }
}
