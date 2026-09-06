using FishingApi.Interfaces;
using FishingApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FishController : ControllerBase
    {
        private readonly IFishService _fishService;

        public FishController(IFishService fishService)
        {
            _fishService = fishService;
        }

        [HttpGet]
        public IActionResult GetFish()
        {
            var fish = _fishService.GetFish();
            return Ok(fish);
        }

        [HttpGet]
        public IActionResult GetBigFish(double minWeight)
        {
            var fish = _fishService.GetBigFish(minWeight);
            return Ok(fish);
        }

        [HttpGet("{id}")]
        public IActionResult GetFishById(int id)
        {
            var fish = _fishService.GetFishById(id);

            if (fish == null)
            {
                return NotFound();
            }


            return Ok(fish);
        }
    }
}
