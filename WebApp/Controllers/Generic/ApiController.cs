using Domain;
using Entities;
using Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController<T, E> : ControllerBase
        where T : IDbRepository<E>
        where E : class, IDbEntity
    {

        T _repository;
        private ITeacherRepository repository;

        public ApiController(T repository)
        {
            _repository = repository;
        }

        public ApiController(ITeacherRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public virtual async Task<IEnumerable<E>> Get()
        {
            return await _repository.ToListAsync();
        }
        [HttpGet("{id}")]
        public virtual async Task<E> Get(Guid id)
        {
            return await _repository.GetItemAsync(id);
        }
        [HttpPost]
        public virtual async Task<ActionResult> Post(E obj)
        {
            if (await _repository.AddItemAsync(obj) > 0)
            {
                return new StatusCodeResult(200);
            }
            else
                return new StatusCodeResult(500);
        }

        [HttpPut]
        public virtual async Task<ActionResult> Put(E obj)
        {
            if (await _repository.ChangeItemAsync(obj))
            {
                return new StatusCodeResult(200);
            }
            else
                return new StatusCodeResult(500);
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(Guid id)
        {
            if (await _repository.DeleteItemAsync(id))
            {
                return new StatusCodeResult(200);
            }
            else
                return new StatusCodeResult(500);
        }
    }
    //[Route("api/[controller]")]
    //[ApiController]
    //public class MarksController : ControllerBase
    //{
    //    IMarksRepository _repository;
    //    public MarksController(IMarksRepository repository)
    //    {
    //        _repository = repository;
    //    }

    //    [HttpGet]
    //    public List<Marks> ListData() {

    //        return _repository.AllItems.ToList();   //посмотреть Async!!!
    //    }

    //   // [HttpGet]
    //    //public Marks SetData(Guid Id)
    //    //{

    //    //}

    //    //[HttpPost]
    //    //public bool AddData(Marks mark)
    //    //{

    //    //}

    //    //[HttpPut]
    //    //public bool PutData(Marks mark)
    //    //{

    //    //}

    //    //[HttpDelete]
    //    //public bool DeleteData(Guid Id)
    //    //{

    //    //}
    //}
}
