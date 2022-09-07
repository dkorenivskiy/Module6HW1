using Microsoft.AspNetCore.Mvc;
using Module6HW1.Core.Entities;
using Module6HW1.Core.Interfaces;

namespace Module6HW1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParrotController : Controller
    {
        private readonly IParrotService _parrotService;

        public ParrotController(IParrotService parrotService)
        {
            _parrotService = parrotService;
        }

        [HttpGet("{id}")]
        public Parrot Get([FromRoute]int id)
        {
            return _parrotService.Get(id);
        }

        [HttpPost]
        public void Post([FromBody]Parrot parrot)
        {
            _parrotService.Create(parrot);
        }

        [HttpPut]
        public void Put([FromBody]Parrot parrot)
        {
            _parrotService.Update(parrot);
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute]int id)
        {
            _parrotService.Delete(id);
        }
    }
}
