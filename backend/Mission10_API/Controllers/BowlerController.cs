using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_API.Data;

namespace Mission10_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp) 
        {
        _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowlers> Get()
        {
            var bowlerData = _bowlerRepository.Bowlers
                .Where(x => x.TeamName.TeamName == "Marlins" || x.TeamName.TeamName == "Sharks")
                .ToList();

            return bowlerData;
        }
    }
}
