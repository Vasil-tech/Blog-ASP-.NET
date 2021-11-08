using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_ASP.NET.Models
{
    public class UsersModel
    {
        public UsersModel(string name, string surname, int age, bool isHasCar)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.isHasCar = isHasCar;
        }

        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public bool isHasCar { get; set; }
    }
}