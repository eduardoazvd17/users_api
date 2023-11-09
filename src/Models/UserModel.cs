using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myfirstapi.Models
{

    public class UserModel
    {
        public UserModel(int id, String name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }

        public String Name { get; set; }
    }
}