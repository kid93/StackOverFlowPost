using System;

namespace StackOverFlowPost
{
    class Post : Controls
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; private set; }

        public int CurrentVotes 
        { 
            get
            {
                return _upVote + _downVote;
            }
        }

        public Post()
        {
            CreationDate = DateTime.Now;
        }

    }
}
