using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myfirstapi.Models;

namespace myfirstapi.Repositories
{
    public interface IUserRepository
    {
        List<UserModel> Get();

        UserModel? Get(int id);

        void Add(UserModel user);

        void Update(int id, UserModel user);

        void Delete(int id);
    }
}