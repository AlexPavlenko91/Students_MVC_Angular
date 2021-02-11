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
    [Route("api/marks")]
    [ApiController]
    public class MarksController : ApiController<IMarksRepository, Marks>
    {
        public MarksController(IMarksRepository repository):base(repository) 
        {
        }
    }
}
