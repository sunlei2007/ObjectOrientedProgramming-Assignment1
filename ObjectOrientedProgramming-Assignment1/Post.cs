using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_Assignment1
{
    public class Post
    {
        private int _Id;
        public int Id { get { return _Id; } }
        private string _body;
        public string Body
        {
            get { return _body; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Body cannot be empty!");
                }
                if (value.Length < 10 || value.Length > 250)
                {
                    throw new Exception("Body must be between 20 and 250!");
                }

                _body = value;

            }
        }
        public DateTime PostDate { get; set; }

        public User user { get; set; }
        public Post(int id,string body)
        {
            _Id = id;
            Body = body;
            PostDate= DateTime.Now;
        }

    }
}
