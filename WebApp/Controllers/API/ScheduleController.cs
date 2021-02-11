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
    [Route("api/schedule")]
    [ApiController]
    public class ScheduleController : ApiController<IScheduleRepository, Schedule>
    {
        public ScheduleController(IScheduleRepository repository) : base(repository)
        {
        }
    }
}
