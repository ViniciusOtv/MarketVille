using MarktVille.Models;
using System.Collections.Generic;

namespace MarktVille.Repository
{
    public interface IUserRepository
    {
       IEnumerable<User> GetUser();

       IEnumerable<User> GetUserById(int? id);
    }
}
