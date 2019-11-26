using MarktVille.Models;
using System.Collections.Generic;


namespace MarktVille.Repository
{
    public interface ISubCategoryRepository
    {
        IEnumerable<SubCategory> GetSubCategorieByCategoryId(int id);
    }
}