using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_Assignment1
{
    public class User
    {
        private int _Id;
        public int Id { get { return _Id; } }
        string _userName;
        public string UserName 
        {
            get { return _userName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("UserName cannot be empty!");
                }
                if (value.Length <= 3 || value.Length >= 20)
                {
                    throw new Exception("UserName must be between 3 and 20!");
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^[0-9a-zA-Z]*$"))
                {
                    throw new Exception("UserName must be number and letters!");
                }
                _userName = value;

            }
        }
        private int _age;
        public int Age 
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Age must exceed zero");
                }
            }
        }

        public HashSet<Post> posts = new HashSet<Post>();
        public User(int id, string uerName, int age)
        {
            _Id = id;
            UserName = uerName;
            Age = age;
        }

    }
}
