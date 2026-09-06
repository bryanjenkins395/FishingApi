using FishingApi.Interfaces;
using FishingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingApi.Services
{
    public class FishService : IFishService
    {
        public List<Fish> GetFish()
        {
            return new List<Fish>
            {
                new Fish {Id = 1, Species = "Largemmouth Bass", Weight= 5.2},
                new Fish {Id = 2, Species = "Crappie", Weight= 1.1},
                new Fish {Id = 3, Species = "Largemouth Bass",Weight= 7.4}
            };
        }

        public List<Fish> GetBigFish(double minWeight)
        {
            return GetFish().Where(f => f.Weight >= minWeight).ToList();
        }

        public Fish? GetFishById(int id)
        {
            return GetFish().FirstOrDefault(f => f.Id == id);
        }
    }
}
