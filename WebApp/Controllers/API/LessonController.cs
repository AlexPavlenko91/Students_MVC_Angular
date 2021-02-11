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
    [Route("api/lesson")]
    [ApiController]
    public class LessonController : ApiController<ILessonRepository, Lesson>
    {
        public LessonController(ILessonRepository repository) : base(repository)
        {
        }
    }
}
