using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingChallenge2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingChallenge2.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        Letter[] letters = new Letter[]
        {
            new Letter { Id = 0, Char = "A" },
            new Letter { Id = 1, Char = "B" },
            new Letter { Id = 2, Char = "C" },
            new Letter { Id = 3, Char = "D" }
        };
        // GET api/values
        [HttpGet]
        public IEnumerable<Letter> Get()
        {
            return letters;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var letter = letters.FirstOrDefault((p) => p.Id == id);
            
            return letter.ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
