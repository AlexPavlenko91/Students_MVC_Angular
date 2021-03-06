﻿using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [Route("api/subject")]
    [ApiController]
    public class SubjectController : ApiController<ISubjectRepository, Subject>
    {
        public SubjectController(ISubjectRepository repository) : base(repository)
        {
        }
    }
}
