﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadPay724.Data.DatabaseContext;
using MadPay724.Data.infrastructures;
using Microsoft.AspNetCore.Mvc;

namespace MadPay724.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IUnitOfWork<MadPayDBContext> _db;

        public ValuesController(IUnitOfWork<MadPayDBContext> context)
        {
            _db = context;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<string> Post([FromBody] string value)
        {
            return null;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<string> Put(int id, [FromBody] string value)
        {
            return null;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return null;
        }
    }
}
