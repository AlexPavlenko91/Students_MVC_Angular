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
    [Route("api/classRoom")]
    [ApiController]
    public class ClassRoomController : ApiController<IClassRoomRepository, ClassRoom>
    {
        public ClassRoomController(IClassRoomRepository repository) : base(repository)
        {
        }
    }
}
