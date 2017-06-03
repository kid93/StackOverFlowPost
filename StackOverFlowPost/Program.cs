using System;

namespace StackOverFlowPost
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Post post = new Post();
            post.Title = "My title";
            post.Description = "My description";

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();

            Console.WriteLine("Post Title: {0}", post.Title);
            Console.WriteLine("Post Description: {0}", post.Description);
            Console.WriteLine(String.Format("Post Creation Date: {0:MMM dd} \'{0:yy} at {0:HH:mm}", post.CreationDate));
            Console.WriteLine("Post Votes: {0}", post.CurrentVotes);


            // OUTPUT
            // Post Title: My title
            // Post Description: My description
            // Post Creation Date: Jun 03 '17 at 23:17
            // Post Votes: 2
          
        }
    }
}
