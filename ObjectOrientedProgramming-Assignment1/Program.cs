using ObjectOrientedProgramming_Assignment1;

try
{
    int userId1 = SocialMediaSystem.CreateUser("John", 20);

    int postId1 = SocialMediaSystem.CreatePostByUser(userId1, "I like your content!");
    int postId2 = SocialMediaSystem.CreatePostByUser(userId1, "Perfect, I like your content!");
    int postId3 = SocialMediaSystem.CreatePostByUser(userId1, "Good job, I like your content!");
    int postId4 = SocialMediaSystem.CreatePostByUser(userId1, "It looks very cool!");

    int reactionId1 = SocialMediaSystem.AddReaction(userId1, postId1, 1); //1:like 0:unlike
    int reactionId2 = SocialMediaSystem.AddReaction(userId1, postId2, 1); //1:like 0:unlike

    //The post Reacted cannot react it again
    int reactionId3 = SocialMediaSystem.AddReaction(userId1, postId1, 1); //1:like 0:unlike
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}
