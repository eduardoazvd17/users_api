using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using myfirstapi.Models;

namespace myfirstapi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<UserModel> _usersTempDb = new List<UserModel>();

        public List<UserModel> Get()
        {
            return _usersTempDb;
        }

        public UserModel? Get(int Id)
        {
            return _usersTempDb.Find(x => x.Id == Id);
        }

        public void Add(UserModel user)
        {
            _usersTempDb.Add(user);
        }

        public void Update(int id, UserModel user)
        {
            UserModel? currentUser = _usersTempDb.Find(x => x.Id == id);
            if (currentUser != null)
            {
                _usersTempDb.Remove(currentUser);
                _usersTempDb.Add(user);
            }
        }

        public void Delete(int Id)
        {
            var user = _usersTempDb.Find(x => x.Id == Id);
            if (user != null)
            {
                _usersTempDb.Remove(user);
            }
        }
    }
}