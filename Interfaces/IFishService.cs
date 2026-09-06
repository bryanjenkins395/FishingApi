using FishingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingApi.Interfaces
{
    public interface IFishService
    {
        List<Fish> GetFish();

        List<Fish> GetBigFish(double minWeight);

        Fish? GetFishById(int id);
    }
}
