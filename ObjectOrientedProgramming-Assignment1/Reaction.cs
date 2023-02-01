using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_Assignment1
{
    public class Reaction
    {
        private int _Id;
        public int Id { get { return _Id; } }
        public User? ReactionUser { get; set; }
        public Post? ReactionPost { get; set; }

        public int ReactionType { get; set; } //1:Like 0:Unlike
        public Reaction(int id, User user, Post post,int reactionType) 
        {  
            _Id= id;
            ReactionUser= user; 
            ReactionPost= post;
            ReactionType= reactionType;
        }

    }
}
