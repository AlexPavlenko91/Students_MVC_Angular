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
    [Route("api/group")]
    [ApiController]
    public class GroupController : ApiController<IGroupRepository, Group>
    {
        public GroupController(IGroupRepository repository) : base(repository)
        {
        }
    }
}
