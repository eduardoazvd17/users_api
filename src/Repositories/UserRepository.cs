using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using myfirstapi.Models;
using myfirstapi.src.Database;

namespace myfirstapi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _db;

        public UserRepository(DatabaseContext db)
        {
            _db = db;
        }

        public List<UserModel> Get()
        {
            var result = _db.Users.OrderBy(x => x.Id);
            return result.ToList();
        }

        public UserModel? Get(int id)
        {
            return _db.Users.Find(id);
        }

        public void Add(UserModel user)
        {
            _db.Add(user);
            _db.SaveChanges();
        }

        public void Update(int id, UserModel user)
        {
            UserModel? currentUser = _db.Users.Find(id);
            if (currentUser != null)
            {
                _db.Update(user);
                _db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var user = _db.Users.Find(id);
            if (user != null)
            {
                _db.Remove(user);
                _db.SaveChanges();
            }
        }
    }
}