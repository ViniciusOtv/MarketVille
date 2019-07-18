using MarktVille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Repository
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetAllLocations();

    }
}
