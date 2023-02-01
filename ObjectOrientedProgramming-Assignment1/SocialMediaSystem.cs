using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_Assignment1
{
    public static class SocialMediaSystem
    {
       private static HashSet<User> users =new HashSet<User>();
       private static HashSet<Post> posts = new HashSet<Post>();
       private static HashSet<Reaction> reactions = new HashSet<Reaction>();

        static int userCounter = 100;
        static int postCounter = 200;
        static int rectionCounter = 300;
        public static int CreateUser(string userName,int age)
        {
            userCounter++;
            User user = new User(userCounter, userName, age);
            users.Add(user);

            Console.WriteLine($"Create user {userName}");
            return user.Id;

        }
        public static int CreatePostByUser(int userId,string body)
        {
            User user = users.Where(x => x.Id == userId).First();

            postCounter++;
            Post post = new Post(postCounter,body);
            post.user = user;
            posts.Add(post);

            user.posts.Add(post);

            Console.WriteLine($"{user.UserName} created post {post.Id}: {body}");
            return post.Id;

        }
        public static int AddReaction(int userId,int postId,int reactionType)
        {
            if (IsReacted(userId,postId, reactionType))
            {
                throw new Exception($"You have reacted the post {postId} is {(reactionType == 1 ? "Like" : "Unlike")}!");
            }
            User user = users.Where(x => x.Id == userId).First();
            Post post= posts.Where(x => x.Id == postId).First();

            rectionCounter++;
            Reaction reaction = new Reaction(rectionCounter, user, post, reactionType);
            reactions.Add(reaction);

            Console.WriteLine($"{user.UserName} created reaction for {post.Id} is {(reactionType == 1 ? "Like" : "Unlike")}");
            return reaction.Id;
        }
        public static bool IsReacted(int userId,int postId,int reactionType)
        {
            var item= reactions.Where(e=>e.ReactionUser.Id==userId && e.ReactionPost.Id==postId && e.ReactionType==reactionType).FirstOrDefault();
            if (item == null)
            {
                return false;
            }
            return true;
        }
    }
}
