using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendKelasA.DAL;
using BackendKelasA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendKelasA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DokterController : ControllerBase
    {
        private IDokter _dokter;
        public DokterController(IDokter dokter)
        {
            _dokter = dokter;
        }

        // GET: api/Dokter
        [HttpGet]
        public async Task<IEnumerable<Dokter>> Get()
        {
            var results = await _dokter.GetAll();
            return results;
        }

        // GET: api/Dokter/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Dokter
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Dokter/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
