using MarktVille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Repository
{
    public interface IStoreRepository
    {
        IEnumerable<Store> GetAllStores();

        IEnumerable<Store> GetStoreById(int id);

        IEnumerable<Product> GetProductStore(int id);

        IEnumerable<Store> GetTopStore();
    }
}
